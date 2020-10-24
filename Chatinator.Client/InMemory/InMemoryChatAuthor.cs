using Chatinator.Client.Interfaces;
using System;

namespace Chatinator.Client.InMemory
{
    class InMemoryChatAuthor : IChatAuthor
    {
        public Guid Id { get; }

        public string DisplayName { get; }

        internal InMemoryChatAuthor(Guid id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }
    }
}
