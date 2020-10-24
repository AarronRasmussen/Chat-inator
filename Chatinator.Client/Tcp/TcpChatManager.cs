using Chatinator.Client.Interfaces;
using System;
using System.Threading.Tasks;

namespace Chatinator.Client.Tcp
{
    class TcpChatManager : IChatManager
    {
        TcpChatChannel _currentChannel = new TcpChatChannel(
            Guid.NewGuid(),
            "Chatinator - #general",
            new TcpChatUser(Guid.NewGuid(), "root")
        );

        public IChatChannel CurrentChannel => _currentChannel;


    }
}