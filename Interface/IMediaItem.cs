using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IMediaItem
    {
        int Id
        {
            get;
            set;
        }

        string Title
        {
            get;
            set;
        }
       ItemStatus status
        {
            get;
            set;
        }
        List<Enums.Languages> Languages
        {
            get;
            set;
        }

    }
}
