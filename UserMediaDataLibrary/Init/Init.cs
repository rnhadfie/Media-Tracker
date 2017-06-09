using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace UserMediaDataLibrary.Init
{
    public class Init
    {
        static  string path = System.Environment.CurrentDirectory.Remove(75) + "UserMediaDataLibrary\\Xml\\";
        static BookData bddb;
        public static void InitData()
        {
        
        
            

        }

        public static void SaveData()
        {
          
            bddb.WriteXml(path + "BookData.xml");

        }
    }
}
