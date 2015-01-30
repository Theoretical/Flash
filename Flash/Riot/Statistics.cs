using System;
using System.Threading.Tasks;
using Flash.Riot.platform.statistics;
using Flash.Riot.platform.client;

namespace Flash.Riot
{
    partial class Client
    {
        public Task<AggregatedStats> GetAggregatedStats(Double summonerId, string mode, String season)
        {
            return Invoke<AggregatedStats>("playerStatsService", "getAggregatedStats", summonerId, "CLASSIC", season);
        }

        public Task <dynamic> ProcessEloQuestionaire(string value="RTS_PLAYER")
        {
            return Invoke<dynamic>("playerStatsService", "processEloQuestionaire", value);
        }

        public Task<SummonerLeaguesDTO> GetAllMyLeagues()
        {
            return Invoke<SummonerLeaguesDTO>("leaguesServiceProxy", "getAllMyLeagues");
        }

        public Task<SummonerLeaguesDTO> GetAllLeaguesForPlayer(Double SummonerId)
        {
            return Invoke<SummonerLeaguesDTO>("leaguesServiceProxy", "getAllLeaguesForPlayer", SummonerId);
        }
    }
}
