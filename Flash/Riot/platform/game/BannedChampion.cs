using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.BannedChampion")]
    public class BannedChampion
    {
        [SerializedName("pickTurn")]
        public Int32 pickTurn { get; set; }

        [SerializedName("championId")]
        public Int32 championId { get; set; }

        [SerializedName("teamId")]
        public Int32 teamId { get; set; }
    }
}
