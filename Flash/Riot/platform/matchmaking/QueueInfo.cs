using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.matchmaking
{
    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.QueueInfo")]
    public class QueueInfo
    {
        [SerializedName("waitTime")]
        public Double WaitTime { get; set; }

        [SerializedName("queueId")]
        public Double QueueId { get; set; }

        [SerializedName("queueLength")]
        public Int32 QueueLength { get; set; }
    }
}
