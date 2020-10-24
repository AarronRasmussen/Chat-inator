using Chatinator.Client.Interfaces;
using System;

namespace Chatinator.Client.InMemory
{
    class InMemoryChatUser : InMemoryChatAuthor, IChatUser
    {
        internal InMemoryChatUser(Guid id, string displayName) : base(id, displayName)
        {
        }
    }
}
