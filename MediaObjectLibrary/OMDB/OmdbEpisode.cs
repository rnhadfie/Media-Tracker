using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaObjectLibrary.OMDB
{
   public  class OmdbEpisode
    {
        public string Title { get; set; }
        public string Released { get; set; }
        public string imdbRating { get; set; }
        public string imdbID { get; set; }
    }
}
