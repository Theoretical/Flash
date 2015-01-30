using System;
using RtmpSharp.IO;

namespace Flash.Riot.kudos
{
    [Serializable]
    [SerializedName("com.riotgames.kudos.dto.PendingKudosDTO")]
    public class PendingKudosDTO
    {
        [SerializedName("pendingCounts")]
        public Int32[] PendingCounts { get; set; }
    }
}
