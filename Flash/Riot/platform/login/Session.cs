using RtmpSharp.IO;
using Flash.Riot.platform.account;
using System;

namespace Flash.Riot.platform.login
{
    [Serializable]
    [SerializedName("com.riotgames.platform.login.Session")]
    public class Session
    {
        [SerializedName("token")]
        public String Token { get; set; }

        [SerializedName("password")]
        public String Password { get; set; }

        [SerializedName("accountSummary")]
        public AccountSummary AccountSummary { get; set; }
    }
}
