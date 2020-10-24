using System;

namespace Chatinator.Shared.Packets
{
    public class SendMessagePayload : Payload
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid ChannelId { get; set; }
    }
}
