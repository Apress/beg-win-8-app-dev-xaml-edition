using MovieBrowser.Common;

namespace MovieBrowser.DataModel
{
    public class Title : BindableBase
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetProperty(ref _name, value);
            }
        }

        private string _shortName;
        public string ShortName
        {
            get 
            { 
                return _shortName; 
            }
            set 
            { 
                SetProperty(ref _shortName, value); 
            }
        }

        private string _synopsis;
        public string Synopsis
        {
            get 
            { 
                return _synopsis; 
            }
            set 
            { 
                SetProperty(ref _synopsis, value); 
            }
        }

        private string _shortSynopsis;
        public string ShortSynopsis
        {
            get 
            { 
                return _shortSynopsis; 
            }
            set 
            { 
                SetProperty(ref _shortSynopsis, value); 
            }
        }

        private BoxArt _boxArt;
        public BoxArt BoxArt
        {
            get
            {
                return _boxArt;
            }
            set
            {
                SetProperty(ref _boxArt, value);
            }
        }
    }
}
