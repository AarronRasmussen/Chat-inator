using System;
using Chatinator.Client.InMemory;
using Chatinator.Client.Interfaces;
using Chatinator.Client.Tcp;
using Chatinator.Client.UI;
using Terminal.Gui;

namespace Chatinator.Client
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Application.Init();
            Colors.Base.Normal = Application.Driver.MakeAttribute(Color.White, Color.Black);

            IChatManager manager = new TcpChatManager();

            ChatView chatView = new ChatView
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Channel = manager.CurrentChannel,
            };

            Application.Top.Add(chatView);
            Application.Run();
        }
    }
}
