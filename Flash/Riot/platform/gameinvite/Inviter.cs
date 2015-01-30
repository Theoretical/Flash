using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.gameinvite
{
    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.Inviter")]
    public class Inviter
    {
        [SerializedName("previousSeasonHighestTier")]
        public string PreviousSeasonHighestTier { get; set; }

        [SerializedName("summonerName")]
        public String SummonerName { get; set; }

        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
    }
}
