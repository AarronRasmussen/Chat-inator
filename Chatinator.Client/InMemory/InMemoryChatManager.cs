using Chatinator.Client.Interfaces;
using System;
using System.Threading.Tasks;

namespace Chatinator.Client.InMemory
{
    class InMemoryChatManager : IChatManager
    {
        InMemoryChatChannel _currentChannel = new InMemoryChatChannel(
            Guid.NewGuid(),
            "Chatinator - #general",
            new InMemoryChatUser(Guid.NewGuid(), "root")
        );

        IChatAuthor _fakeUser = new InMemoryChatAuthor(Guid.NewGuid(), "system");

        public IChatChannel CurrentChannel => _currentChannel;

        internal InMemoryChatManager()
        {
            _ = SendFakeMessagesAsync();
        }

        async Task SendFakeMessagesAsync()
        {
            var i = 0;

            while (true)
            {
                await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
                _currentChannel.SendFakeMessage(_fakeUser, (++i).ToString());
            }
        }
    }
}
