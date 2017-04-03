using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaObjectsInterface
{
    public interface IMediaItem
    {
        string ID { get; set; }
        string Title { get; set; }
        string YearReleased { get; set; }
        string[] Langauge { get; set; }
    }
}
