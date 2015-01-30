using System;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using RtmpSharp.IO;
using RtmpSharp.Net;
using RtmpSharp.Messaging;
using Flash.Riot.platform.login;
using Flash.Riot.Region;
using System.Timers;
using System.Diagnostics;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace Flash.Riot
{
    public partial class Client
    {
        private RtmpClient _client;
        private BaseRegion _region;
        private Session _session;
        private string _version;
        private string _user;
        private bool _auth;
        private Int32 _heartbeatCount;
        private Timer _heartbeatTimer;
        private DateTime _uptime;
        private EventHandler<MessageReceivedEventArgs> _backupHandler;
        private EventHandler _backupDisconnected;

        public Client(BaseRegion region, string version)
        {
            _heartbeatCount = 0;
            _region = region;
            _version = version;
            _client = new RtmpClient(new Uri(string.Format("rtmps://{0}:2099", region.Server)), GetContext(), ObjectEncoding.Amf3);
        }

        public void Disconnect()
        {
            _client.Disconnected -= _backupDisconnected;
            _client.MessageReceived -= _backupHandler;

            if (!_client.IsDisconnected)
                _client.Close();

            _auth = false;
            _heartbeatCount = 0;
            if (_heartbeatTimer != null)
                _heartbeatTimer.Stop();
        }

        public void SetMessageReceived(EventHandler<MessageReceivedEventArgs> handler)
        {
            _client.MessageReceived += handler;
            _backupHandler = handler;
        }

        public void SetDisconnectHandler(EventHandler handler)
        {
            _client.Disconnected += handler;
            _backupDisconnected = handler;
        }

        public RtmpClient GetRtmpClient()
        {
            return _client;
        }

        public bool Ready { get { return _auth;  } }
        public string ClientId { get { return _user + "-" + _region.Code; } }

        public TimeSpan Uptime { get { return DateTime.Now - _uptime; } }

        public async Task<bool> Connect(string user, string pass)
        {
            try
            {
                _user = user;
                await _client.ConnectAsync();

                var cred = new AuthenticationCredentials();
                cred.Username = user;
                cred.Password = pass;
                cred.ClientVersion = _version;
                cred.Domain = "lolclient.lol.riotgames.com";
                cred.IpAddress = GetIpAddress();
                cred.Locale = "en_US";
                cred.AuthToken = GetAuthToken(_region, user, pass);
            
                if (cred.AuthToken == "RETRY")
                {
                    Log.Error("[{0}] Login queue error!", _user);
                    Disconnect();
                    return await Connect(user, pass);
                }

                _session = await Login(cred);

                await _client.SubscribeAsync("my-rtmps", "messagingDestination", "bc", "bc-" + _session.AccountSummary.AccountId.ToString());
                await _client.SubscribeAsync("my-rtmps", "messagingDestination", "gn-" + _session.AccountSummary.AccountId.ToString(), "gn-" + _session.AccountSummary.AccountId.ToString());
                await _client.SubscribeAsync("my-rtmps", "messagingDestination", "cn-" + _session.AccountSummary.AccountId.ToString(), "cn-" + _session.AccountSummary.AccountId.ToString());
                var loggedIn = await _client.LoginAsync(user.ToLower(), _session.Token);

                _auth = true;
                //Log.Write("[{0}] Logged in!", _session.AccountSummary.Username);

                _heartbeatTimer = new Timer();
                _heartbeatTimer.Elapsed += new ElapsedEventHandler(Heartbeat);
                _heartbeatTimer.Interval = 120000;
                _heartbeatTimer.Start();

                _uptime = DateTime.Now;
                return true;
            }
            catch (InvocationException e)
            {
            }
            catch (ClientDisconnectedException)
            {
            }
            catch (System.Net.WebException ex)
            {
                var res = (System.Net.HttpWebResponse)ex.Response;
                if (res != null && (int)res.StatusCode == 403)
                {
                    using(var reader = new StreamReader(res.GetResponseStream()))
                    {
                        var body = reader.ReadToEnd();
                        var jsonSerializer = new JavaScriptSerializer();
                        var json = jsonSerializer.Deserialize<Dictionary<string, object>>(body);
                        
                        Log.Write("[{0}] Error on login: {1}", user, json["reason"]);
                        if (Convert.ToString(json["reason"]) == "attempt_rate_too_fast")
                        {
                            Log.Write("[{0}] Waiting 5 seconds due to throttle from Riot.", user);
                            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));

                            //Log.Close();
                            //Process.Start(Environment.CurrentDirectory + "\\Summoning.exe");
                            //Environment.Exit(0);
                        }
                    }

                    return false;
                }
            }
            catch(Exception e)
            {
                Log.Write("[{0}] Exception while authing: {1}", user, e.Message);
                return false;
            }
            _client.Close();
            return await Connect(user, pass);
        }

        public SerializationContext GetContext()
        {
            var context = new SerializationContext();
            var assembly = Assembly.GetExecutingAssembly();

            foreach (var account in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.account")).ToList())
                context.Register(account);
                        
            foreach (var login in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.login")))
                context.Register(login);

            foreach (var game in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.game")))
                context.Register(game);

            foreach (var stats in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.statistics")))
                context.Register(stats);

            foreach (var matchmaking in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.matchmaking")))
                context.Register(matchmaking);

            foreach (var gameinvite in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.gameinvite")))
                context.Register(gameinvite);

            foreach (var broadcast in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.broadcast")))
                context.Register(broadcast);

            foreach (var system in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.systemstate")))
                context.Register(system);

            foreach (var clientFacade in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.clientfacade")))
                context.Register(clientFacade);

            foreach (var summoner in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.summoner")))
                context.Register(summoner);

            foreach (var catalog in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.catalog")))
                context.Register(catalog);

            foreach (var kudos in assembly.GetTypes().Where(t => t.Namespace.Contains("kudos")))
                context.Register(kudos);

            foreach (var team in assembly.GetTypes().Where(t => t.Namespace.Contains("team")))
                context.Register(team);

            foreach (var league in assembly.GetTypes().Where(t => t.Namespace.Contains("leagues")))
                context.Register(league);

            foreach (var client in assembly.GetTypes().Where(t => t.Namespace.Contains("platform.client")))
                context.Register(client);


            return context;
         }

        private async void Heartbeat(object sender, ElapsedEventArgs e)
        {
            if (Ready)
            {
                try
                {
                    var error = await PerformLCDSHeartBeat(Convert.ToInt32(_session.AccountSummary.AccountId), _session.Token, _heartbeatCount,
                        DateTime.Now.ToString("ddd MMM d yyyy HH:mm:ss 'GMTZ'"));
                    _heartbeatCount++;

                    if (error == null)
                    {
                        Log.Error("[{0}] Security error!", _user);
                        return;
                    }
                }
                catch(ClientDisconnectedException)
                {
                    Log.Error("[{0}] - Disconnected.", _session.AccountSummary.Username);
                    return;
                }
                catch(Exception ex)
                {
                    Log.Error("[{0}] - Error: {1}", _session.AccountSummary.Username, ex);
                    return;
                }
            }
        }

        public async void Reset()
        {
            _auth = false;
            _heartbeatCount = 0;
            _heartbeatTimer.Stop();

            _client.Close();
            _client = new RtmpClient(new Uri(string.Format("rtmps://{0}:2099", _region.Server)), GetContext(), ObjectEncoding.Amf3);
            _client.MessageReceived += _backupHandler;
            _client.Disconnected += _backupDisconnected;
            await Connect(_session.AccountSummary.Username, _session.Password);
        }

        public Task<T> Invoke<T>(string destination, string method, params object[] args)
        {
            try
            {
                Log.Invoke(destination, method);
                return _client.InvokeAsync<T>("my-rtmps", destination, method, args);
            }
            catch(InvocationException e)
            {
                Log.Error("Invocation Exception: {0}", e);
                return null;
            }
        }
    }
}
