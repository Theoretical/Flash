using System;
using RtmpSharp.IO;
using System.Collections.Generic;

namespace Flash.Riot.platform.gameinvite
{
    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.InvitationRequest")]
    public class InvitationRequest
    {
        [SerializedName("inviter")]
        public Inviter Inviter { get; set; }

        [SerializedName("inviteType")]
        public string InviteType { get; set; }

        [SerializedName("gameMetaData")]
        public object GameMetaData { get; set; }

        [SerializedName("owner")]
        public Player Owner { get; set; }

        [SerializedName("invitationStateAsString")]
        public string InvitationStateAsString { get; set; }

        [SerializedName("invitationState")]
        public string InvitationState { get; set; }

        [SerializedName("inviteTypeAsString")]
        public string InviteTypeAsString { get; set; }

        [SerializedName("invitationId")]
        public string InvitationId { get; set; }
    }
}
