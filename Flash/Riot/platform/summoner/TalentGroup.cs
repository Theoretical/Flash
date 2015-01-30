using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Flash.Riot.platform.summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.TalentGroup")]
    public class TalentGroup
    {
        [SerializedName("index")]
        public Int32 Index { get; set; }

        [SerializedName("talentRows")]
        public List<TalentRow> TalentRows { get; set; }

        [SerializedName("name")]
        public String Name { get; set; }

        [SerializedName("tltGroupId")]
        public Int32 TltGroupId { get; set; }
    }
}
