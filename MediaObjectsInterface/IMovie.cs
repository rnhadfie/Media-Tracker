using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaObjectsInterface
{
    public interface IMovie:IMediaItem
    {
       string Rating { get; set; }
       string Runtime { get; set; }
       string[] Genre { get; set; }
        string[] Director { get; set; }
        string[] Writers { get; set; }
        string[] Actors { get; set; }
        string Plot { get; set; }
        
    }
}
