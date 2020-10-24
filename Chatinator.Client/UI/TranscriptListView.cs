using System;
using System.Collections.Generic;
using Terminal.Gui;

namespace Chatinator.Client.UI
{
    internal sealed class TranscriptListView : ListView
    {
        public Action ScrollChanged { get; set; }

        readonly List<string> _items;

        public int BottomItem
        {
            get => Math.Min(Source.Count, TopItem + Frame.Height - 1);
            set
            {
                TopItem = Math.Max(value - Frame.Height + 1, 0);
                ScrollChanged?.Invoke();
            }
        }

        public TranscriptListView(List<string> items) : base(items)
        {
            _items = items;
        }

        public void AddItem(string message, bool forceScrollToBottom = false)
        {
            var topItem = TopItem;
            var scrolledToBottom = BottomItem == Source.Count - 1;

            _items.Add(message);
            Source = Source;

            if (forceScrollToBottom || scrolledToBottom)
            {
                BottomItem = Source.Count - 1;
            }
            else
            {
                TopItem = topItem;
                ScrollChanged?.Invoke();
            }
        }
    }
}
