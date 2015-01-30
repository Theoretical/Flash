using Flash.Riot.platform.gameinvite;
using Flash.Riot.platform.matchmaking;
using System;
using System.Threading.Tasks;

namespace Flash.Riot
{
    public partial class Client
    {
        public Task<LobbyStatus> CreateArrangedTeamLobby(double queueId)
        {
            return Invoke<LobbyStatus>("lcdsGameInvitationService", "createArrangedTeamLobby", queueId);
        }

        public Task<LobbyStatus> CreateArrangedBotTeamLobby(double queueId, string difficulty)
        {
            return Invoke<LobbyStatus>("lcdsGameInvitationService", "createArrangedBotTeamLobby", queueId, difficulty);
        }

        public Task<LobbyStatus> CreateGroupFinderLobby(double queueId, string groupId)
        {
            return Invoke<LobbyStatus>("lcdsGameInvitationService", "createGroupFinderLobby", queueId, groupId);
        }

        public Task<dynamic> DestroyGroupFinderLobby()
        {
            return Invoke<dynamic>("lcdsGameInvitationService", "destroyGroupFinderLobby");
        }
        public Task<dynamic> Invite(double summonerId)
        {
            return Invoke<dynamic>("lcdsGameInvitationService", "invite", summonerId);
        }

        public Task<dynamic> Kick(double summonerId)
        {
            return Invoke<dynamic>("lcdsGameInvitationService", "kick", summonerId);
        }

        public Task<dynamic> Leave()
        {
            return Invoke<dynamic>("lcdsGameInvitationService", "leave");
        }


        public Task<dynamic> Accept(string invitationId)
        {
            return Invoke<dynamic>("lcdsGameInvitationService", "accept", invitationId);
        }
        public Task<dynamic> GetPendingInvitations()
        {
            return Invoke<dynamic>("lcdsGameInvitationService", "getPendingInvitations");
        }
        
        public Task<GameQueueConfig[]> GetAvailableQueues()
        {
            return Invoke<GameQueueConfig[]>("matchmakerService", "getAvailableQueues", new object[]{});
        }

        public Task<SearchingForMatchNotification> AttachToQueue(MatchMakerParams matchmakerParams)
        {
            return Invoke<SearchingForMatchNotification>("matchmakerService", "attachToQueue", matchmakerParams);
        }

        public Task<SearchingForMatchNotification> attachTeamToQueue(MatchMakerParams matchmakerParams)
        {
            return Invoke<SearchingForMatchNotification>("matchmakerService", "attachTeamToQueue", matchmakerParams);
        }
    }
}
