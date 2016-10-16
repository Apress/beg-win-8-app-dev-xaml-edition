using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace SimpleBindingCs
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            var results = DoSearch(criteriaTextBox.Text);
            // remove anything that's already in the list
            resultList.Items.Clear();

            foreach (var result in results)
            {
                var listItem = new ListBoxItem();
                listItem.Content = result.Title;
                listItem.Tag = result;

                resultList.Items.Add(listItem);
            }
        }

        private IEnumerable<Entities.SearchResultItem> DoSearch(string criteria)
        {
            return new[]
            {
                new Entities.SearchResultItem
                {
                    Title = "Bread",
                    Summary = "Good for sandwiches"
                },
                new Entities.SearchResultItem
                {
                    Title = "Peanut Butter",
                    Summary = "Goes on the sandwiches"
                }
            };
        }
    }
}
