using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.PlayerChampionSelectionDTO")]
    public class PlayerChampionSelectionDTO
    {
        [SerializedName("summonerInternalName")]
        public String summonerInternalName { get; set; }

        [SerializedName("spell2Id")]
        public Double spell2Id { get; set; }

        [SerializedName("selectedSkinIndex")]
        public Int32 selectedSkinIndex { get; set; }

        [SerializedName("championId")]
        public Int32 championId { get; set; }

        [SerializedName("spell1Id")]
        public Double spell1Id { get; set; }
    }
}
