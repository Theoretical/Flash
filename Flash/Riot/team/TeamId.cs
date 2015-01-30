using System;
using RtmpSharp.IO;
namespace Flash.Riot.team
{
    [Serializable]
    [SerializedName("com.riotgames.team.TeamId")]
    public class TeamId
    {
        [SerializedName("broadcastMessages")]
        public object[] BroadcastMessages { get; set; }
    }
}
