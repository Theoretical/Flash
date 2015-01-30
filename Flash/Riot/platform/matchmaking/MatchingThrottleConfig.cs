using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Flash.Riot.platform.matchmaking
{
    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.MatchingThrottleConfig")]
    public class MatchingThrottleConfig
    {
        [SerializedName("limit")]
        public Double Limit { get; set; }

        [SerializedName("matchingThrottleProperties")]
        public List<object> MatchingThrottleProperties { get; set; }

        [SerializedName("cacheName")]
        public String CacheName { get; set; }
    }
}
