using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMediaDataLibrary.Init
{
    class FillType
    {
        DataSet userMedia = new DataSet();
        private void LoadDataSet()
        {
            userMedia.ReadXmlSchema("UserMediaSchema.xsd");
            userMedia.ReadXml("Type.xml");
        }
        public FillType()
        {
            LoadDataSet();
            // int i = userMedia.Tables.IndexOf("Genre");
            //DataTable genres = userMedia.Tables[i];

            // DataRow row = genres.NewRow();

        }
    }
}
