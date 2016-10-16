using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using MovieBrowser.DataModel;

namespace MovieBrowser.Utility
{
    public static class NetflixXmlHelper
    {
        private static readonly XNamespace AtomNamespace = XNamespace.Get("http://www.w3.org/2005/Atom");
        private static readonly XNamespace DataServiceNamespace = XNamespace.Get("http://schemas.microsoft.com/ado/2007/08/dataservices");
        private static readonly XNamespace MetadataNamespace = XNamespace.Get("http://schemas.microsoft.com/ado/2007/08/dataservices/metadata");

        public static class AtomNodeNames
        {
            public static readonly XName Entry = AtomNamespace.GetName("entry");
            public static readonly XName Title = AtomNamespace.GetName("title");
            public static readonly XName Id = AtomNamespace.GetName("id");
        }

        public static class MetadataNodeNames
        {
            public static readonly XName Properties = MetadataNamespace.GetName("properties");
        }

        public static class DataServiceNodeNames
        {
            public static readonly XName Name = DataServiceNamespace.GetName("Name");
            public static readonly XName ShortName = DataServiceNamespace.GetName("ShortName");
            public static readonly XName Synopsis = DataServiceNamespace.GetName("Synopsis");
            public static readonly XName ShortSynopsis = DataServiceNamespace.GetName("ShortSynopsis");
            public static readonly XName BoxArt = DataServiceNamespace.GetName("BoxArt");
            public static readonly XName SmallUrl = DataServiceNamespace.GetName("SmallUrl");
            public static readonly XName MediumUrl = DataServiceNamespace.GetName("MediumUrl");
            public static readonly XName LargeUrl = DataServiceNamespace.GetName("LargeUrl");
        }

        public static Title ParseTitle(XElement titleElement)
        {
            var propertiesElement = titleElement.Element(MetadataNodeNames.Properties);
            var title = new Title();

            title.Name = propertiesElement.Element(DataServiceNodeNames.Name).Value;
            title.ShortName = propertiesElement.Element(DataServiceNodeNames.ShortName).Value;
            title.Synopsis = propertiesElement.Element(DataServiceNodeNames.Synopsis).Value;
            title.ShortSynopsis = propertiesElement.Element(DataServiceNodeNames.ShortSynopsis).Value;

            var boxArtElement = propertiesElement.Element(DataServiceNodeNames.BoxArt);
            var boxArt = new BoxArt();
            boxArt.SmallUrl = new Uri(boxArtElement.Element(DataServiceNodeNames.SmallUrl).Value);
            boxArt.MediumUrl = new Uri(boxArtElement.Element(DataServiceNodeNames.MediumUrl).Value);
            boxArt.LargeUrl = new Uri(boxArtElement.Element(DataServiceNodeNames.LargeUrl).Value);

            title.BoxArt = boxArt;
            return title;
        }

        public static async Task<XDocument> GetGenresXml()
        {
            using (var webClient = new HttpClient())
            {
                var response = await webClient.GetStringAsync("http://odata.netflix.com/v2/catalog/Genres?$select=Name&$top=10");
                return XDocument.Parse(response);
            }
        }
    }
}
