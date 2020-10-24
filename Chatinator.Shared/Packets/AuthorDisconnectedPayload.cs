using System;

namespace Chatinator.Shared.Packets
{
    public class AuthorDisconnectedPayload : Payload
    {
        public Guid AuthorId { get; set; }
    }
}
