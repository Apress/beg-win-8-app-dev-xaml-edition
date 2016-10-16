
using MovieBrowser.DataModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

namespace MovieBrowser
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class GroupedItemsPage : MovieBrowser.Common.LayoutAwarePage
    {
        public GroupedItemsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when a group header is clicked.
        /// </summary>
        /// <param name="sender">The Button used as a group header for the selected group.</param>
        /// <param name="e">Event data that describes how the click was initiated.</param>
        void Header_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as MovieBrowserViewModel;
            var genre = (sender as FrameworkElement).DataContext as Genre;
            vm.SelectGenreCommand.Execute(genre);
        }

        /// <summary>
        /// Invoked when an item within a group is clicked.
        /// </summary>
        /// <param name="sender">The GridView (or ListView when the application is snapped)
        /// displaying the item clicked.</param>
        /// <param name="e">Event data that describes the item clicked.</param>
        void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var vm = DataContext as MovieBrowserViewModel;
            var title = e.ClickedItem as Title;
            vm.SelectTitleCommand.Execute(title);
        }
    }
}
