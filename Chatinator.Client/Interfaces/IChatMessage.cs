using System;

namespace Chatinator.Client.Interfaces
{
    interface IChatMessage
    {
        IChatAuthor Author { get; }

        DateTimeOffset PostedAt { get; }

        string Text { get; }
    }
}
