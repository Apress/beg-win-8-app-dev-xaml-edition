using System;
using MovieBrowser.Data;
using MovieBrowser.DataModel;
using MovieBrowser.Interfaces;

namespace MovieBrowser.ServiceAgents
{
    class SampleDataMovieCatalogServiceAgent : IMovieCatalogServiceAgent
    {
        public void InitiateGenreRetrieval(Action<Genre> GenreAvailableCallback)
        {
            var catalog = new SampleMovieDataSource();
            foreach (var genre in catalog.Genres)
            {
                GenreAvailableCallback(genre);
            }
        }
    }
}
