using System;
using MovieBrowser.Common;

namespace MovieBrowser.DataModel
{
    public class BoxArt : BindableBase
    {
        private Uri _smallUrl;
        public Uri SmallUrl
        {
            get
            {
                return _smallUrl;
            }
            set
            {
                SetProperty(ref _smallUrl, value);
            }
        }

        private Uri _mediumUrl;
        public Uri MediumUrl
        {
            get
            {
                return _mediumUrl;
            }
            set
            {
                SetProperty(ref _mediumUrl, value);
            }
        }

        private Uri _largeUrl;
        public Uri LargeUrl
        {
            get
            {
                return _largeUrl;
            }
            set
            {
                SetProperty(ref _largeUrl, value);
            }
        }
    }
}
