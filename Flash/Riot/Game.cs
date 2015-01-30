using System;
using System.Threading.Tasks;
using Flash.Riot.platform.game;

namespace Flash.Riot
{
    partial class Client
    {
        public Task<dynamic> CreateTutorialGame(uint isBasic = 1)
        {
            return Invoke<dynamic>("gameService", "createTutorialGame", new object[] { isBasic });
        }

        public Task<PlatformGameLifecycleDTO> RetrieveInProgressSpectatorGameInfo(string name)
        {
            return Invoke<PlatformGameLifecycleDTO>("gameService", "retrieveInProgressSpectatorGameInfo", name);
        }

        public Task<PracticeGameSearchResult[]> ListAllPracticeGames()
        {
            return Invoke<PracticeGameSearchResult[]>("gameService", "listAllPracticeGames", new object[] { });
        }

        public Task<GameDTO> CreatePracticeGame(PracticeGameConfig config)
        {
            return Invoke<GameDTO>("gameService", "createPracticeGame", config);
        }

        public Task<object> JoinGame(double id, string password = null)
        {
            return Invoke<object>("gameService", "joinGame", new object[] { id, password });
        }

        public Task<dynamic> StartChampionSelect(double GameId, double OptomisticLock)
        {
            return Invoke<dynamic>("gameService", "startChampionSelection", new object[] { GameId, OptomisticLock });
        }

        public Task<Object> SelectChampion(Int32 ChampionId)
        {
            return Invoke<Object>("gameService", "selectChampion", ChampionId);
        }

        public Task<Object> ChampionSelectCompleted()
        {
            return Invoke<Object>("gameService", "championSelectCompleted");
        }

        public Task<dynamic> SetClientReceivedGameMessage(double gameId, string arg)
        {
            return Invoke<dynamic>("gameService", "setClientReceivedGameMessage", gameId, arg);
        }

        public Task<dynamic> AcceptPoppedGame(Boolean AcceptGame)
        {
            return Invoke<dynamic>("gameService", "acceptPoppedGame", AcceptGame);
        }
    }
}
