using System;
using RtmpSharp.IO;

namespace Flash.Riot.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.PlayerParticipant")]
    public class PlayerParticipant : Participant
    {
        [SerializedName("timeAddedToQueue")]
        public object timeAddedToQueue { get; set; }

        [SerializedName("index")]
        public Int32 index { get; set; }

        [SerializedName("queueRating")]
        public Int32 queueRating { get; set; }

        [SerializedName("accountId")]
        public Double accountId { get; set; }

        [SerializedName("botDifficulty")]
        public String botDifficulty { get; set; }

        [SerializedName("originalAccountNumber")]
        public Double originalAccountNumber { get; set; }

        [SerializedName("summonerInternalName")]
        public String summonerInternalName { get; set; }

        [SerializedName("minor")]
        public Boolean minor { get; set; }

        [SerializedName("locale")]
        public object locale { get; set; }

        [SerializedName("lastSelectedSkinIndex")]
        public Int32 lastSelectedSkinIndex { get; set; }

        [SerializedName("partnerId")]
        public String partnerId { get; set; }

        [SerializedName("profileIconId")]
        public Int32 profileIconId { get; set; }

        [SerializedName("teamOwner")]
        public Boolean teamOwner { get; set; }

        [SerializedName("summonerId")]
        public Double summonerId { get; set; }

        [SerializedName("badges")]
        public Int32 badges { get; set; }

        [SerializedName("pickTurn")]
        public Int32 pickTurn { get; set; }

        [SerializedName("clientInSynch")]
        public Boolean clientInSynch { get; set; }

        [SerializedName("summonerName")]
        public String summonerName { get; set; }

        [SerializedName("pickMode")]
        public Int32 pickMode { get; set; }

        [SerializedName("originalPlatformId")]
        public String originalPlatformId { get; set; }

        [SerializedName("teamParticipantId")]
        public object teamParticipantId { get; set; }
    }
}
