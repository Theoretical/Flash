using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.PlatformGameLifecycleDTO")]
    public class PlatformGameLifecycleDTO
    {
        [SerializedName("gameSpecificLoyaltyRewards")]
        public object gameSpecificLoyaltyRewards { get; set; }

        [SerializedName("reconnectDelay")]
        public Int32 reconnectDelay { get; set; }

        [SerializedName("lastModifiedDate")]
        public object lastModifiedDate { get; set; }

        [SerializedName("game")]
        public GameDTO game { get; set; }

        [SerializedName("playerCredentials")]
        public PlayerCredentialsDto playerCredentials { get; set; }

        [SerializedName("gameName")]
        public String gameName { get; set; }

        [SerializedName("connectivityStateEnum")]
        public object connectivityStateEnum { get; set; }
    }
}
