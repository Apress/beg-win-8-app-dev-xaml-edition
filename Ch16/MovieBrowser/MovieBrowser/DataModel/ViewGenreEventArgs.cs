
using System;
namespace MovieBrowser.DataModel
{
    public class ViewGenreEventArgs : EventArgs
    {
        public ViewGenreEventArgs(Genre genre)
        {
            Genre = genre;
        }

        public Genre Genre
        {
            get;
            private set;
        }
    }
}
