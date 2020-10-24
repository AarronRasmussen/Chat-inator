using System;

namespace Chatinator.Shared.Packets
{
    public class SentMessagePayload : Payload
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid ChannelId { get; set; }
        public Guid AuthorId { get; set; }
        public DateTimeOffset PostedAt { get; set; }
    }
}
