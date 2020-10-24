using Chatinator.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chatinator.Client.InMemory
{
    class InMemoryChatMessage : IChatMessage
    {
        public IChatAuthor Author { get; }

        public DateTimeOffset PostedAt { get; }

        public string Text { get; }

        internal InMemoryChatMessage(IChatAuthor author, DateTimeOffset postedAt, string text)
        {
            Author = author;
            PostedAt = postedAt;
            Text = text;
        }
    }
}
