using System;

namespace MovieBrowser.DataModel
{
    public class ViewTitleEventArgs : EventArgs
    {
        public ViewTitleEventArgs(Title title)
        {
            Title = title;
        }

        public Title Title
        {
            get;
            private set;
        }
    }
}
