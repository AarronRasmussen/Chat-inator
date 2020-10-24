using System.Collections.Generic;
using Terminal.Gui;

namespace Chatinator.Client.UI
{
    internal sealed class ChatView : View
    {
        internal TranscriptListView ListView { get; }
        internal ScrollBarView ListScrollBarView { get; }
        internal ComposeTextView TextView { get; }

        public ChatView()
        {
            ListView = new TranscriptListView(new List<string>())
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill() - 1,
                Height = Dim.Fill(),
                CanFocus = false,
                ScrollChanged = UpdateListScrolBarOffset
            };

            ListScrollBarView = new ScrollBarView(default, 1, 0, true)
            {
                LayoutStyle = LayoutStyle.Computed,
                X = Pos.AnchorEnd(1),
                Y = 0,
                Width = 1,
                Height = Dim.Fill(),
            };

            var listFrame = new FrameView("Chatinator")
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = Dim.Fill() - 5,
            };

            listFrame.Add(ListView, ListScrollBarView);

            TextView = new ComposeTextView
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Text = "",
                SendMessage = ProcessUserMessage,
                ScrollKeyPressed = ProcessScrollKeyPressed,
            };

            var textFrame = new FrameView(null)
            {
                X = 0,
                Y = Pos.AnchorEnd(5),
                Width = Dim.Fill(),
                Height = 5,
            };

            textFrame.Add(TextView);

            Add(listFrame);
            Add(textFrame);
        }

        void UpdateListScrolBarOffset()
        {
            ListScrollBarView.Size = ListView.Source.Count;
            ListScrollBarView.Position = ListView.TopItem;
        }

        void ProcessUserMessage(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return;
            }

            if (text == "/quit" || text == "/exit")
            {
                Application.RequestStop();
            }
            else
            {
                TextView.Text = "";
                ListView.AddItem(text, true);
            }
        }

        void ProcessScrollKeyPressed(int offset)
        {
            if (offset < 0 && ListView.TopItem > 0)
            {
                ListView.TopItem -= 1;
            }
            else if (offset > 0 && ListView.BottomItem + 1 < ListView.Source.Count)
            {
                ListView.BottomItem += 1;
            }
        }
    }
}
