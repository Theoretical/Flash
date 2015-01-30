using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.gameinvite
{
    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.Member")]
    public class Member
    {
        [SerializedName("summonerId")]
        public Double SummonerId;

        [SerializedName("summonerName")]
        public String SummonerName;

        [SerializedName("hasDelegatedInvitePower")]
        public Boolean HasDelegatedInvitePower;
    }
}
