using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaObjectLibrary.OMDB
{
   public class OmdbSeason
    {
        public string Title { get; set; }
        public string Season { get; set; }
        public string totalSeasons { get; set; }
        public List<OmdbEpisode> Episodes { get; set; }
    }
}
