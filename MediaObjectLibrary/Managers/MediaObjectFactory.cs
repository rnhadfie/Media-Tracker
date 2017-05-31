using MediaObjectLibrary.OMDB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MediaObjectLibrary.Managers
{
   public class MediaObjectFactory
    {
        private static List<OmdbSearch> _ListOfSeries;
        private static List<OmdbSearch> _ListOfMovies;

        private static string searchURL = "http://www.omdbapi.com/?s=";
        private static string FindTitleURL = "http://www.omdbapi.com/?t=";
        private static string FindIdURL = "http://www.omdbapi.com/?i=";
        private static int _PageTotal;
        public MediaObjectFactory()
        {
            _ListOfSeries = new List<OmdbSearch>();
            _ListOfMovies = new List<OmdbSearch>();
        }
        public static List<OmdbSearch> OrganizeMedia(List<OmdbSearch> items, string type)
        {
            foreach (OmdbSearch item in items)
            {
                if (item.Type.Equals("Series"))
                {
                   
                    _ListOfSeries.Add(item);
                }
                else if (item.Type.Equals("Movie"))
                {
                   // OmdbMovie temp = GetMovieItemInformation(item.imdbID);
                   
                    _ListOfMovies.Add(item);
                }
            }
            if (type.Equals("Series"))
            {
                return _ListOfSeries;
            }
            else {
                return _ListOfMovies;
                }
            }

        public static int PageTotal { get { return _PageTotal; } }
        public List<OmdbSearch> ListOfSeries { get { return _ListOfSeries; } }
        public List<OmdbSearch> ListOfMovies { get { return _ListOfMovies; } }



        public static List<OmdbSearch> Search(string title)
        {
            using (WebClient wc = new WebClient())
            {
                //string url = "http://www.omdbapi.com/?s=" + itemTitle.Trim();
                var json = wc.DownloadString((searchURL + title + "&Page=1").Trim());
                if (!json.Contains("No API key provided")) { 
                var jsonist = json.Split('[')[1];
                int index = json.IndexOf("totalResults");
                string pages = json.Substring(index, 20);
                string s = "";
                foreach (char c in pages.ToArray<char>())
                {
                    if (Char.IsDigit(c))
                        s += c.ToString();
                }
                decimal d = decimal.Parse(s) / 10m;
                _PageTotal = (int)Math.Ceiling(d);
                jsonist = "[" + jsonist.Split(']')[0] + "]";

                var result = JsonConvert.DeserializeObject<List<OmdbSearch>>(jsonist);
                
                return result;
            }
            return null;
        }
        }
        public static List<OmdbSearch> Search(string title, int page)
        {
            using (WebClient wc = new WebClient())
            {

                //string url = "http://www.omdbapi.com/?s=" + itemTitle.Trim();
                var json = wc.DownloadString((searchURL + title + "&Page=" + page.ToString()).Trim());
                if (json != null)
                {
                    var jsonist = json.Split('[')[1];
                    // _PageTotal = GetTotalPageNumber(json.Split(']')[1]);
                    jsonist = "[" + jsonist.Split(']')[0] + "]";

                    var result = JsonConvert.DeserializeObject<List<OmdbSearch>>(jsonist);
                    return result;
                }
            }

            return null;
        }
       

        public static OmdbTvShow GetTvShowItemInformation(string id)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString((FindIdURL + id).Trim());
                var result = JsonConvert.DeserializeObject<OmdbTvShow>(json);
                return result;
            }
        }
        public static OmdbMovie GetMovieItemInformation(string id)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString((FindIdURL + id).Trim());
                var result = JsonConvert.DeserializeObject<OmdbMovie>(json);
                return result;
            }
        }
        public static OmdbSeason GetSeasonInformation(string id, int season)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString((FindIdURL + id + "&Season=" + season.ToString()).Trim());
                var result = JsonConvert.DeserializeObject<OmdbSeason>(json);
                return result;
            }
        }
    }

}