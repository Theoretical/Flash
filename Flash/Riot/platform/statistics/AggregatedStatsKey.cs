using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.AggregatedStatsKey")]
    public class AggregatedStatsKey
    {
        [SerializedName("gameMode")]
        public String GameMode { get; set; }

        [SerializedName("userId")]
        public Double UserId { get; set; }

        [SerializedName("gameModeString")]
        public String GameModeString { get; set; }
    }
}
