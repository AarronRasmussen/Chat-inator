using Chatinator.Client.Interfaces;
using System;

namespace Chatinator.Client.Tcp
{
    class TcpChatAuthor : IChatAuthor
    {
        public Guid Id { get; }

        public string DisplayName { get; }

        internal TcpChatAuthor(Guid id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }
    }
}
