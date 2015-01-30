using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;
using Flash.Riot.platform.login;
using Flash.Riot.platform.clientfacade;
using Flash.Riot.Region;
using RtmpSharp.IO;
using System.Collections.Generic;
using System.Collections;

namespace Flash.Riot
{
    public partial class Client
    {
        public Task<string> GetStoreUrl()
        {
            return Invoke<string>("loginService", "getStoreUrl", new object[]{});
        }
        public Task<Session> Login(AuthenticationCredentials auth)
        {
            return Invoke<Session>("loginService", "login", auth);
        }

        public Task<string> PerformLCDSHeartBeat(Int32 accountId, String sessionToken, Int32 heartbeatCount, String currentTime)
        {
            return Invoke<String>("loginService", "performLCDSHeartBeat", accountId, sessionToken, heartbeatCount, currentTime);
        }

        public Task<LoginDataPacket> GetLoginDataPacketForUser()
        {
            return Invoke<LoginDataPacket>("clientFacadeService", "getLoginDataPacketForUser", new object[] { });
        }

        public Task<String> GetAccountState()
        {
            return Invoke<String>("accountService", "getAccountStateForCurrentSession", new object[] {});
        }

        public string GetAuthToken(BaseRegion region, string user, string pass)
        {

            ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, error) =>
            {
                return true;
            };

            var argString = string.Format("payload=user={0},password={1}", user, pass);
            var argBytes = Encoding.ASCII.GetBytes(argString);
            var body = "";
            
            var req = WebRequest.Create(string.Format("{0}login-queue/rest/queue/authenticate", region.LoginQueue));
            req.Method = "POST";
            req.Proxy = null;
            req.Timeout = 25000;

            req.GetRequestStream().Write(argBytes, 0, argBytes.Length);

            var response = req.GetResponse();

            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                body = stream.ReadToEnd();
                stream.Close();
            }

            var jsonSerializer = new JavaScriptSerializer();
            var json = jsonSerializer.Deserialize<Dictionary<string, object>>(body);

            if (json.ContainsKey("token"))
                return (string)json["token"];

            if ((string)json["reason"] == "login_rate")
            {
                var node = (int)json["node"];
                var champ = (string)json["champ"];
                var rate = (int)json["rate"];
                var delay = (int)json["delay"];
                var id = -1;
                var current = -1;


                foreach (var element in (ArrayList)json["tickers"])
                {
                    var tick = (Dictionary<string, object>)element;
                    if ((int)tick["node"] == node)
                    {
                        id = (int)tick["id"];
                        current = (int)tick["current"];
                    }
                }

                while (id - current > rate)
                {
                    req = WebRequest.Create(string.Format("{0}login-queue/rest/queue/ticket/{1}", region.LoginQueue, champ));
                    req.Proxy = null;
                    using (var reader = new StreamReader(req.GetResponse().GetResponseStream()))
                    {
                        body = reader.ReadToEnd();
                        reader.Close();
                    }

                    json = jsonSerializer.Deserialize<Dictionary<string, object>>(body);

                    current = (int)json["current"];
                    Log.Write("[{0}] In login-queue. Position: {1}", user, id - current);
                }

                if (json.ContainsKey("token"))
                    return (string)json["token"];


                while (true)
                {
                    try
                    {
                        req = WebRequest.Create(string.Format("{0}login-queue/rest/queue/authToken/{1}", region.LoginQueue, user.ToLower()));
                        req.Proxy = null;
                        using (var reader = new StreamReader(req.GetResponse().GetResponseStream()))
                        {
                            body = reader.ReadToEnd();
                            body.Clone();
                        }


                        return jsonSerializer.Deserialize<Dictionary<string, object>>(body)["token"] as string;
                    }
                    catch
                    {

                    }
                    System.Threading.Thread.Sleep(750);
                }
            }

            return "";
        }

        public static string GetIpAddress()
        {
            var sb = new StringBuilder();

            var con = WebRequest.Create("http://ll.leagueoflegends.com/services/connection_info");
            con.Proxy = null;
            WebResponse response = con.GetResponse();

            int c;
            while ((c = response.GetResponseStream().ReadByte()) != -1)
                sb.Append((char)c);

            con.Abort();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, string> deserializedJSON = serializer.Deserialize<Dictionary<string, string>>(sb.ToString());

            return deserializedJSON["ip_address"];
        }

    }
}
