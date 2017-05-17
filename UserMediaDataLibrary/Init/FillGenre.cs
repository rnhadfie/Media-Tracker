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
        DataSet userMedia = new DataSet();
        private void LoadDataSet()
        {
            userMedia.ReadXmlSchema("UserMediaSchema.xsd");
            userMedia.ReadXml("Type.xml");
            userMedia.WriteXmlSchema("UserMediaSchema.xsd");
        }
        public FillGenre()
        {
            LoadDataSet();
            int i=userMedia.Tables.IndexOf("Genre");
            DataTable genres = userMedia.Tables[i];

            DataRow row= genres.NewRow();
            row["GenreCode"].
        }   
    }
}
