using System;

namespace Chatinator.Shared.Packets
{
    public class JoinPayload : Payload
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
    }
}
