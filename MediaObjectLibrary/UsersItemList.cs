using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaObjectsInterface;

namespace MediaObjectLibrary
{
    class UsersItemList
    {
        public List<IMediaItem> UsersItems;
        private static bool HasInit = false;
        private static UsersItemList singeleton;
        private UsersItemList()
        {
            UsersItems = new List<IMediaItem>();
            HasInit = true;
        }
        public static UsersItemList InitUserList()
        {
            if (!HasInit)
            {
                singeleton=new UsersItemList();
                
            }
            return singeleton;
        }
    }
}
