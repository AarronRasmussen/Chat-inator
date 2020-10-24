using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chatinator.Client.Interfaces
{
    interface IChatChannel
    {
        event Action<IChatMessage> OnMessageReceived;

        Guid Id { get; }

        string DisplayName { get; }

        IList<IChatMessage> Messages { get; }

        ISet<IChatUser> OnlineUsers { get; }

        Task SendMessageAsync(string text);
    }
}
