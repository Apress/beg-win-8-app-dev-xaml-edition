using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using RssReaderCs.Entities;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RssReaderCs
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage : Page
    {
        private ObservableCollection<FeedItem> _feedItems = new ObservableCollection<FeedItem>();

        public BlankPage()
        {
            this.InitializeComponent();
            FeedList.ItemsSource = FeedItems;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        public async Task<List<FeedItem>> DownloadFeedAsync()
        {
            const string feedUrl = "http://blogs.msdn.com/b/ericlippert/rss.aspx?Tags=async";
            List<FeedItem> result = new List<FeedItem>();

            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = int.MaxValue;
            var response = await client.GetStringAsync(feedUrl);

            var doc = XDocument.Parse(response);
            
            return doc.Descendants("item").Select(item =>
                new FeedItem { Title = item.Element("title").Value }
                ).ToList();
        }

        public ObservableCollection<FeedItem> FeedItems { get { return _feedItems; } }

        private async void OnRetrieveButtonClicked(object sender, RoutedEventArgs e)
        {
            _feedItems.Clear();
            var feedResults = await DownloadFeedAsync();
            foreach (var item in feedResults)
            {
                _feedItems.Add(item);
            }
        }
    }
}
