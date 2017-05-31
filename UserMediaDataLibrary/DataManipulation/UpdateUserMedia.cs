using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMediaDataLibrary.DataManipulation
{

    class UpdateUserMedia
    {
       static DataSet ds = new DataSet();
        public static void Update(int id, string name, int status, int type, List<int> genres)
        {
            ds.ReadXmlSchema("UserMediaSchema.xsd");
            DataTable dt = ds.Tables["UserMedia"];
            DataRow r = dt.NewRow();
            r[dt.Columns.IndexOf("ItemId")] = id;
            r[dt.Columns.IndexOf("Name")] = name;
            r[dt.Columns.IndexOf("Status")]= status;
            r["Type"]= type;

            dt.Rows.Add(r);
            dt.AcceptChanges();
            dt = ds.Tables["ItemGenres"];
            foreach (int genre in genres)
            {
                DataRow row = dt.NewRow();
                row["ItemId"] = id;
                row["GenreCode"] = genre;
                dt.Rows.Add(row);
            }
            dt.AcceptChanges();
            ds.AcceptChanges();
            ds.WriteXml("");
            
        }
    }
}
