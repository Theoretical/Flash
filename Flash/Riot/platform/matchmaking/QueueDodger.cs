using System;
using RtmpSharp.IO;
using Flash.Riot.platform.summoner;

namespace Flash.Riot.platform.matchmaking
{
    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.QueueDodger")]
    public class QueueDodger
    {
        [SerializedName("reasonFailed")]
        public string ReasonFailed { get; set; }

        [SerializedName("summoner")]
        public Summoner Summoner { get; set; }

        [SerializedName("dodgePenaltyRemainingTime")]
        public Int32 PenaltyRemainingTime { get; set; }
    }
}
