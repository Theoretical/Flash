using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.gameinvite
{
    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.Player")]
    public class Player
    {
        [SerializedName("summonerName")]
        public String SummonerName { get; set; }

        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
    }
}
