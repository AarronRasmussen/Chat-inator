using System;
using System.Collections.Generic;
using System.Text;

namespace Chatinator.Client.Interfaces
{
    interface IChatManager
    {
        IChatChannel CurrentChannel { get; }
    }
}
