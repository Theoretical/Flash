using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Flash.Riot.platform.summoner.spellbook
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.spellbook.SpellBookPageDTO")]
    public class SpellBookPageDTO
    {
        [SerializedName("slotEntries")]
        public List<SlotEntry> SlotEntries { get; set; }

        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }

        [SerializedName("createDate")]
        public DateTime CreateDate { get; set; }

        [SerializedName("name")]
        public String Name { get; set; }

        [SerializedName("pageId")]
        public Int32 PageId { get; set; }

        [SerializedName("current")]
        public Boolean Current { get; set; }
    }
}
