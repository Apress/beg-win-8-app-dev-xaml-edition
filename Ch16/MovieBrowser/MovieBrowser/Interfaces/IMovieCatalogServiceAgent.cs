using System;
using MovieBrowser.DataModel;

namespace MovieBrowser.Interfaces
{
    public interface IMovieCatalogServiceAgent
    {
        void InitiateGenreRetrieval(Action<Genre> GenreAvailableCallback);
    }
}
