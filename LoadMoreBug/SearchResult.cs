using System;
using System.ComponentModel;

namespace LoadMoreBug
{
    public class SearchResult:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string LabelText { get; set; }

        public SearchResult(string text)
        {
            LabelText = text;
        }
    }
}
