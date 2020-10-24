using System;

namespace Chatinator.Shared.Packets
{
    public class AuthorJoinedPayload : Payload
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public bool ShouldBroadcastToChannel { get; set; }
    }
}
