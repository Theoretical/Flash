using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.GameObserver")]
    public class GameObserver
    {
        [SerializedName("accountId")]
        public Double accountId { get; set; }

        [SerializedName("botDifficulty")]
        public String botDifficulty { get; set; }

        [SerializedName("summonerInternalName")]
        public String summonerInternalName { get; set; }

        [SerializedName("locale")]
        public object locale { get; set; }

        [SerializedName("lastSelectedSkinIndex")]
        public Int32 lastSelectedSkinIndex { get; set; }

        [SerializedName("partnerId")]
        public String partnerId { get; set; }

        [SerializedName("profileIconId")]
        public Int32 profileIconId { get; set; }

        [SerializedName("summonerId")]
        public Double summonerId { get; set; }

        [SerializedName("badges")]
        public Int32 badges { get; set; }

        [SerializedName("pickTurn")]
        public Int32 pickTurn { get; set; }

        [SerializedName("originalAccountId")]
        public Double originalAccountId { get; set; }

        [SerializedName("summonerName")]
        public String summonerName { get; set; }

        [SerializedName("pickMode")]
        public Int32 pickMode { get; set; }

        [SerializedName("originalPlatformId")]
        public String originalPlatformId { get; set; }
    }
}
