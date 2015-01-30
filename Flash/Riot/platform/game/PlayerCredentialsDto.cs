using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.PlayerCredentialsDto")]
    public class PlayerCredentialsDto
    {
        [SerializedName("encryptionKey")]
        public String encryptionKey { get; set; }

        [SerializedName("gameId")]
        public Double gameId { get; set; }

        [SerializedName("lastSelectedSkinIndex")]
        public Int32 lastSelectedSkinIndex { get; set; }

        [SerializedName("serverIp")]
        public String serverIp { get; set; }

        [SerializedName("observer")]
        public Boolean observer { get; set; }

        [SerializedName("summonerId")]
        public Double summonerId { get; set; }

        [SerializedName("observerServerIp")]
        public String observerServerIp { get; set; }

        [SerializedName("handshakeToken")]
        public String handshakeToken { get; set; }

        [SerializedName("playerId")]
        public Double playerId { get; set; }

        [SerializedName("serverPort")]
        public Int32 serverPort { get; set; }

        [SerializedName("observerServerPort")]
        public Int32 observerServerPort { get; set; }

        [SerializedName("summonerName")]
        public String summonerName { get; set; }

        [SerializedName("observerEncryptionKey")]
        public String observerEncryptionKey { get; set; }

        [SerializedName("championId")]
        public Int32 championId { get; set; }
    }
}
