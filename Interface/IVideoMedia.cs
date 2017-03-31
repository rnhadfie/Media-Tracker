using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IVideoMedia:IMediaItem
    {
        
        Enums.Ratings Rating
        {
            get;
            set;
        }
        string Director
        {
            get;
            set;
        }
       
        List<VideoGenres> Genres
        {
            get;
            set;
        }

        

    }
}
