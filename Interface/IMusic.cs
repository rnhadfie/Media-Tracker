using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IMusic:IMediaItem
    {
        string Artist { get; set; }
        
        List<string> Songs { get; set; }
        List<MusicGenres> Genres { get; set; }
    }
}
