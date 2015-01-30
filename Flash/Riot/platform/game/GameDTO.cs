using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Flash.Riot.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.GameDTO")]
    public class GameDTO
    {
        [SerializedName("spectatorsAllowed")]
        public String spectatorsAllowed { get; set; }

        [SerializedName("passwordSet")]
        public Boolean passwordSet { get; set; }

        [SerializedName("gameType")]
        public String gameType { get; set; }

        [SerializedName("gameTypeConfigId")]
        public Int32 gameTypeConfigId { get; set; }

        [SerializedName("glmGameId")]
        public object glmGameId { get; set; }

        [SerializedName("gameState")]
        public String gameState { get; set; }

        [SerializedName("glmHost")]
        public object glmHost { get; set; }

        [SerializedName("observers")]
        public List<GameObserver> observers { get; set; }

        [SerializedName("statusOfParticipants")]
        public object statusOfParticipants { get; set; }

        [SerializedName("glmSecurePort")]
        public Int32 glmSecurePort { get; set; }

        [SerializedName("id")]
        public Double id { get; set; }

        [SerializedName("ownerSummary")]
        public PlayerParticipant ownerSummary { get; set; }

        [SerializedName("teamTwo")]
        public object teamTwo { get; set; }

        [SerializedName("bannedChampions")]
        public List<BannedChampion> bannedChampions { get; set; }

        [SerializedName("roomName")]
        public String roomName { get; set; }

        [SerializedName("name")]
        public String name { get; set; }

        [SerializedName("spectatorDelay")]
        public Int32 spectatorDelay { get; set; }

        [SerializedName("teamOne")]
        public object teamOne { get; set; }

        [SerializedName("terminatedCondition")]
        public String terminatedCondition { get; set; }

        [SerializedName("queueTypeName")]
        public String queueTypeName { get; set; }

        [SerializedName("glmPort")]
        public Int32 glmPort { get; set; }

        [SerializedName("passbackUrl")]
        public object passbackUrl { get; set; }

        [SerializedName("roomPassword")]
        public String roomPassword { get; set; }

        [SerializedName("optimisticLock")]
        public Double optimisticLock { get; set; }

        [SerializedName("maxNumPlayers")]
        public Int32 maxNumPlayers { get; set; }

        [SerializedName("queuePosition")]
        public Int32 queuePosition { get; set; }

        [SerializedName("gameMode")]
        public String gameMode { get; set; }

        [SerializedName("expiryTime")]
        public Double expiryTime { get; set; }

        [SerializedName("mapId")]
        public Int32 mapId { get; set; }

        [SerializedName("banOrder")]
        public List<Int32> banOrder { get; set; }

        [SerializedName("pickTurn")]
        public Int32 pickTurn { get; set; }

        [SerializedName("gameStateString")]
        public String gameStateString { get; set; }

        [SerializedName("playerChampionSelections")]
        public List<PlayerChampionSelectionDTO> playerChampionSelections { get; set; }

        [SerializedName("joinTimerDuration")]
        public Int32 joinTimerDuration { get; set; }

        [SerializedName("passbackDataPacket")]
        public object passbackDataPacket { get; set; }
    }
}
