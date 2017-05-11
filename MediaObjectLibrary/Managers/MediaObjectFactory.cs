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
        private List<OmdbTvShow> _ListOfSeries;
        private List<OmdbMovie> _ListOfMovies;

        private static string searchURL = "http://www.omdbapi.com/?s=";
        private static string FindTitleURL = "http://www.omdbapi.com/?t=";
        private static string FindIdURL = "http://www.omdbapi.com/?i=";
        private static int _PageTotal;
        public MediaObjectFactory()
        {
            _ListOfSeries = new List<OmdbTvShow>();
            _ListOfMovies = new List<OmdbMovie>();
        }
        public void OrganizeMedia(List<OmdbSearch> items)
        {
            foreach (OmdbSearch item in items)
            {
                if (item.Type.Equals("Series"))
                {
                   OmdbTvShow temp = GetTvShowItemInformation(item.imdbID);
                    //OmdbTvShow tvs = new OmdbTvShow();
                    _ListOfSeries.Add(temp);
                }
                else if (item.Type.Equals("Movie"))
                {
                    OmdbMovie temp = GetMovieItemInformation(item.imdbID);
                   
                    _ListOfMovies.Add(temp);
                }
            }
        }

        public int PageTotal { get { return _PageTotal; } }
        public List<OmdbTvShow> ListOfSeries { get { return _ListOfSeries; } }
        public List<OmdbMovie> ListOfMovies { get { return _ListOfMovies; } }



        public static List<OmdbSearch> Search(string title)
        {
            using (WebClient wc = new WebClient())
            {
                //string url = "http://www.omdbapi.com/?s=" + itemTitle.Trim();
                var json = wc.DownloadString((searchURL + title + "&Page=1").Trim());
                var jsonist = json.Split('[')[1];

                //_PageTotal = Convert.ToInt32(jsonist.Split(']')[1].Split(':')[1]);
                jsonist = "[" + jsonist.Split(']')[0] + "]";

                var result = JsonConvert.DeserializeObject<List<OmdbSearch>>(jsonist);
                return result;
            }
        }
        public static List<OmdbSearch> Search(string title, string year)
        {
            using (WebClient wc = new WebClient())
            {
                //string url = "http://www.omdbapi.com/?s=" + itemTitle.Trim();
                var json = wc.DownloadString((searchURL + title + "&Page=1").Trim());
                var jsonist = json.Split('[')[1];
                // _PageTotal = GetTotalPageNumber(json.Split(']')[1]);
                jsonist = "[" + json.Split(']')[0] + "]";

                var result = JsonConvert.DeserializeObject<List<OmdbSearch>>(jsonist);
                return result;
            }
        }
        private static int GetTotalPageNumber(string endOfQuery)
        {


            string temp = endOfQuery.Split(':')[1].ToString();
            string final = temp;
            int i = 0;
            foreach (char c in temp)
            {
                if (Char.IsDigit(c))
                {
                    final = temp.Remove(i + 1);

                }
                i++;
            }
            int _Page = Convert.ToInt32(final.Substring(1));
            return _Page;
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