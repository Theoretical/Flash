using RtmpSharp.IO;
using System;

namespace Flash.Riot.platform.summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.PublicSummoner")]
    public class PublicSummoner
    {
        [SerializedName("internalName")]
        public String internalName { get; set; }

        [SerializedName("acctId")]
        public Double acctId { get; set; }

        [SerializedName("name")]
        public String name { get; set; }

        [SerializedName("profileIconId")]
        public Int32 profileIconId { get; set; }

        [SerializedName("revisionDate")]
        public DateTime revisionDate { get; set; }

        [SerializedName("revisionId")]
        public Double revisionId { get; set; }

        [SerializedName("summonerLevel")]
        public Double summonerLevel { get; set; }

        [SerializedName("summonerId")]
        public Double summonerId { get; set; }
    }
}
