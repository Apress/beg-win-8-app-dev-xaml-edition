using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using MovieBrowser.DataModel;
using MovieBrowser.Interfaces;
using MovieBrowser.Utility;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace MovieBrowser.ServiceAgents
{
    public class NetflixMovieCatalogServiceAgent : IMovieCatalogServiceAgent
    {
        public async void InitiateGenreRetrieval(Action<Genre> genreAvailableCallback)
        {
            var genreDoc = await NetflixXmlHelper.GetGenresXml();

            foreach (var entryNode in genreDoc.Descendants(NetflixXmlHelper.AtomNodeNames.Entry))
            {
                await ProcessGenre(entryNode, genreAvailableCallback);
            }
        }


        private async Task ProcessGenre(XElement genreElement, Action<Genre> genreAvailableCallback)
        {
            const string titleUrlFormat = "{0}/Titles?$top=20&$expand=BoxArt&select=Name,ShortName,Synopsis,ShortSynopsis,BoxArt";
            var titleClient = new HttpClient();
            titleClient.MaxResponseContentBufferSize = int.MaxValue;
            var titleListingUrl = string.Format(titleUrlFormat, genreElement.Element(NetflixXmlHelper.AtomNodeNames.Id).Value);

            var titleResponse = await titleClient.GetStringAsync(titleListingUrl);
            var titleDoc = XDocument.Parse(titleResponse);

            var titleObjects = titleDoc.Descendants(NetflixXmlHelper.AtomNodeNames.Entry).Select(element =>
            {
                return NetflixXmlHelper.ParseTitle(element);
            });

            var genre = new Genre();
            genre.Name = genreElement.Element(NetflixXmlHelper.AtomNodeNames.Title).Value;
            genre.Titles = new ObservableCollection<Title>();
            foreach (var title in titleObjects)
            {
                genre.Titles.Add(title);
            }

            CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal
                , () =>
                {
                    genreAvailableCallback(genre);
                });
        }
    }
}
