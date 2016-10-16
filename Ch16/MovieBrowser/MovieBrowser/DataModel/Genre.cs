using System.Collections.ObjectModel;
using MovieBrowser.Common;

namespace MovieBrowser.DataModel
{
    public class Genre : BindableBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private ObservableCollection<Title> _titles;
        public ObservableCollection<Title> Titles
        {
            get { return _titles; }
            set { SetProperty(ref _titles, value); }
        }
    }
}
