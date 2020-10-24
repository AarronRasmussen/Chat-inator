using Chatinator.Client.Interfaces;
using System;

namespace Chatinator.Client.Tcp
{
    class TcpChatMessage : IChatMessage
    {
        public IChatAuthor Author { get; }

        public DateTimeOffset PostedAt { get; }

        public string Text { get; }

        internal TcpChatMessage(IChatAuthor author, DateTimeOffset postedAt, string text)
        {
            Author = author;
            PostedAt = postedAt;
            Text = text;
        }
    }
}
