using System;
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

            ChatView chatView = new ChatView
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
            };

            StartSendingFakeMessages(chatView);

            Application.Top.Add(chatView);
            Application.Run();
        }

        static void StartSendingFakeMessages(ChatView chatView)
        {
            var i = 0;

            Application.MainLoop.AddTimeout(TimeSpan.FromSeconds(2), runLoop =>
            {
                chatView.ListView.AddItem(i.ToString());
                i++;

                return true;
            });
        }
    }
}
