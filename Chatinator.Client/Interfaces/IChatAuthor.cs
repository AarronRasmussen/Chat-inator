using System;

namespace Chatinator.Client.Interfaces
{
    interface IChatAuthor
    {
        Guid Id { get; }

        string DisplayName { get; }
    }
}
