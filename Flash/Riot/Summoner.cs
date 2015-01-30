using System;
using System.Threading.Tasks;
using Flash.Riot.platform.summoner;
using Flash.Riot.platform.matchmaking;

namespace Flash.Riot
{
    partial class Client
    {
        public Task<PublicSummoner> GetSummonerByName(string name)
        {
            return Invoke<PublicSummoner>("summonerService", "getSummonerByName", name);
        }

        public Task<dynamic> CreateDefaultSummoner(string name)
        {
            return Invoke<dynamic>("summonerService", "createDefaultSummoner", name);
        }

        public Task<dynamic> UpdateProfileIcon(int id)
        {
            return Invoke<dynamic>("summonerService", "updateProfileIconId", id);
        }
        
        public Task<dynamic> SaveSeenTutorialFlag()
        {
            return Invoke<dynamic>("summonerService", "saveSeenTutorialFlag");
        }
 
    }
}
