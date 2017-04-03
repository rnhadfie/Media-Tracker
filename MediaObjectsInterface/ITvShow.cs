using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaObjectsInterface
{
    public interface ITvShow:IMovie
    {
        int Seasons { get; set; }
        string Years { get; set; }
    }
}
