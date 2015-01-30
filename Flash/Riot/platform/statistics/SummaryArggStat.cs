using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.SummaryAggStat")]
    public class SummaryAggStat
    {
        [SerializedName("statType")]
        public String StatType { get; set; }

        [SerializedName("count")]
        public Double Count { get; set; }

        [SerializedName("value")]
        public Double Value { get; set; }
    }
}
