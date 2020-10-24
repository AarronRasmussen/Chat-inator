using System;
using Terminal.Gui;

namespace Chatinator.Client.UI
{
    internal sealed class ComposeTextView : TextView
    {
        public Action<string> SendMessage { get; set; }
        public Action<int> ScrollKeyPressed { get; set; }

        public override bool ProcessKey(KeyEvent kb)
        {
            switch (kb.Key)
            {
                case Key.Enter:
                    SendMessage?.Invoke(Text.ToString()?.Trim());
                    return true;

                case Key.CursorUp:
                    ScrollKeyPressed?.Invoke(-1);
                    return true;

                case Key.CursorDown:
                    ScrollKeyPressed?.Invoke(1);
                    return true;

                case Key.ControlU:
                    Text = "";
                    return true;

                default:
                    return base.ProcessKey(kb);
            }
        }
    }
}
