using Chatinator.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chatinator.Client.InMemory
{
    class InMemoryChatChannel : IChatChannel
    {
        public event Action<IChatMessage> OnMessageReceived;

        public Guid Id { get; }

        public string DisplayName { get; }

        public IList<IChatMessage> Messages { get; } = new List<IChatMessage>();

        public ISet<IChatUser> OnlineUsers { get; } = new HashSet<IChatUser>();

        private IChatAuthor _currentAuthor;

        internal InMemoryChatChannel(Guid id, string displayName, IChatAuthor currentAuthor)
        {
            Id = id;
            DisplayName = displayName;

            _currentAuthor = currentAuthor;
        }
        public Task SendMessageAsync(string text)
        {
            var message = new InMemoryChatMessage(_currentAuthor, DateTimeOffset.Now, text);
            Messages.Add(message);
            OnMessageReceived?.Invoke(message);

            return Task.CompletedTask;
        }

        public void SendFakeMessage(IChatAuthor author, string text)
        {
            var message = new InMemoryChatMessage(author, DateTimeOffset.Now, text);
            Messages.Add(message);
            OnMessageReceived?.Invoke(message);
        }
    }
}
