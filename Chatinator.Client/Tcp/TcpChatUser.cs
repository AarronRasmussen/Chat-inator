using Chatinator.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chatinator.Client.Tcp
{
    class TcpChatUser : TcpChatAuthor, IChatUser
    {
        internal TcpChatUser(Guid id, string displayName) : base(id, displayName)
        {
        }
    }
}
