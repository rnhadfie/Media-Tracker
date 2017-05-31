using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UserMediaDataLibrary.Init
{
    class FillGenre
    {
        public DataSet userMedia = new DataSet();
        private void LoadDataSet()
        {
            userMedia.ReadXmlSchema("UserMediaSchema.xsd");
            userMedia.ReadXml("Type.xml");
            if(userMedia.Tables["Genre"].Rows.Count>0)
                userMedia.WriteXmlSchema("UserMediaSchema.xsd");
        }
        public FillGenre()
        {    
            LoadDataSet();     
        }   
    }
}
