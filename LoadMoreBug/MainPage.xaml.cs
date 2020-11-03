using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoadMoreBug
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<SearchResult> SearchResultsItems { get; set; }
        public ICommand LoadMoreItemsCommand { get; set; }

        public MainPage()
        {
            InitializeComponent();

            SearchResultsItems = new ObservableCollection<SearchResult>();
            for (int i = 0; i < 10; i++)
            {
                SearchResultsItems.Add(new SearchResult("Test " + i.ToString()));
            }
            SearchListView.ItemsSource = SearchResultsItems;

            LoadMoreItemsCommand = new Command<object>(LoadMoreItems, CanLoadMoreItems);
            SearchListView.LoadMoreCommand = LoadMoreItemsCommand;
        }

        private bool CanLoadMoreItems(object obj)
        {
            return true;
        }

        private async void LoadMoreItems(object obj)
        {
            SearchListView.IsBusy = true;

            await Task.Delay(4000);

            for(int i=0; i<10; i++)
            {
                SearchResultsItems.Add(new SearchResult("Test " + i.ToString()));
            }

            SearchListView.IsBusy = false;
        }
    }
}
