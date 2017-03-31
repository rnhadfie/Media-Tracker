using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IGraphicNovel:IMediaItem
    {
        string Author { get; set; }
        
        List<WrittenGenres> Genres { get; set; }
        string Artist { get; set; }
        
    }
}
