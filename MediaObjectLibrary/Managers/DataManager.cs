using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMediaDataLibrary.Init;


namespace MediaObjectLibrary.Managers
{
    public class DataManager
    {
        public static void InitData()
        {
            Init.InitData();
            
        }
        public static void SaveData()
        {
            Init.SaveData();
        }
    }
}
