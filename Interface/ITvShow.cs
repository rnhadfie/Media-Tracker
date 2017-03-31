using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ITvShow:IVideoMedia
    {
        int TotalNumberOfEpisodes { get; set; }
        int TotalNumberOfSeasons { get; set; }
    }
}
