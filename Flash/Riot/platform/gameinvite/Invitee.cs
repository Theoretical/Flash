using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.gameinvite
{
    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.Invitee")]
    public class Invitee
    {
        [SerializedName("InviteeState")]
        public String InviteeState { get; set; }

        [SerializedName("SummonerName")]
        public String SummonerName { get; set; }

        [SerializedName("SummonerId")]
        public Double SummonerId { get; set; }
    }
}
