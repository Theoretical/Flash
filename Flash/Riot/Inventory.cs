using System;
using System.Threading.Tasks;
using Flash.Riot.platform.catalog.champion;
using Flash.Riot.platform.summoner.boost;

namespace Flash.Riot
{
    partial class Client
    {
        public Task<ChampionDTO[]> GetAvailableChampions()
        {
            return Invoke<ChampionDTO[]>("inventoryService", "getAvailableChampions", new object[] { });
        }
        public Task<SummonerActiveBoostsDTO> GetSumonerActiveBoosts()
        {
            return Invoke<SummonerActiveBoostsDTO>("inventoryService", "getSumonerActiveBoosts");
        }

    }
}