using Chatinator.Shared.Packets;
using NUnit.Framework;
using System;

namespace Chatinator.Shared.Tests
{
    public class PacketSerializerTests
    {

        [Test]
        public void TestSerialize()
        {
            var serializer = new PacketSerializer();

            var originalPayload = new SentMessagePayload
            {
                Id = Guid.NewGuid(),
                Text = "Hello There hi",
                ChannelId = Guid.NewGuid(),
                AuthorId = Guid.NewGuid(),
                PostedAt = DateTimeOffset.Now,
            };

            var json = serializer.Serialize(originalPayload);
            var deserializedPayload = (SentMessagePayload)serializer.Deserialize(json);

            Assert.That(deserializedPayload.Id, Is.EqualTo(originalPayload.Id), "Id was incorrect");
            Assert.That(deserializedPayload.Text, Is.EqualTo(originalPayload.Text), "Text was incorrect");
            Assert.That(deserializedPayload.ChannelId, Is.EqualTo(originalPayload.ChannelId), "ChannelId was incorrect");
            Assert.That(deserializedPayload.AuthorId, Is.EqualTo(originalPayload.AuthorId), "AuthorId was incorrect");
            Assert.That(deserializedPayload.PostedAt, Is.EqualTo(originalPayload.PostedAt), "PostedAt was incorrect");
        }
    }
}
