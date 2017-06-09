using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Collections;
using System.Data;
using UserMediaDataLibrary.DataManipulation;

namespace MediaObjectLibrary.Managers
{
   
    public class BookManager
    {
        private UpdateDataTable table = UpdateDataTable.GetSingle();
        Hashtable searchParameters = new Hashtable();
        public BookManager()
        {
            searchParameters.Add("inauthor", null);
            searchParameters.Add("intitle", null);
            searchParameters.Add("searchtext", null);
            searchParameters.Add("orderBy", null);
            searchParameters.Add("printType", null);
            searchParameters.Add("startIndex", null);
            searchParameters.Add("inpublisher", null);
            searchParameters.Add("subject", null);
            searchParameters.Add("isbn", null);
            searchParameters.Add("maxResults", 5);
            

        }
        public static Books.Header LoadBookList(string searchString)
        {
            using (WebClient wc = new WebClient()) {
                String s = "https://www.googleapis.com/books/v1/volumes?q=Log+Horizon";
                var json = wc.DownloadString(searchString);
                Books.Header bookList = JsonConvert.DeserializeObject<Books.Header>(json);

                return bookList;

            }

        }

        public static List<Books.BookItems> LoadUserBookList()
        {
            List<Books.BookItems> listOfBooks = new List<Books.BookItems>();
            using (WebClient wc = new WebClient())
            {
                string s = "https://www.googleapis.com/books/v1/volumes?q=isbn:";
                DataTable bookTable = UpdateDataTable.GetListOfBooks();
                foreach (DataRow r in bookTable.Rows)
                {
                    
                    var json = wc.DownloadString(s+((string)r.ItemArray[0]));
                    Books.Header bookList = JsonConvert.DeserializeObject<Books.Header>(json);
                    Books.BookItems book = bookList.items[0];
                    book.Status = (string)r["Status"];
                    listOfBooks.Add(book);
                }

            }
            return listOfBooks;
        }
        private string BuildQuery(string q)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("https://www.googleapis.com/books/v1/volumes?q=");
            sb.Append(q);
            ICollection keys=searchParameters.Keys;
            foreach (string key in keys)
            {
                if (searchParameters[key] != null)
                {
                    sb.Append("&");
                    sb.Append(key);
                    sb.Append("=");
                    sb.Append(searchParameters[key].ToString());
                }
            }
            string s = sb.ToString();
            return sb.ToString();
        }
        public void UpdateHashTable(string key, string value)
        {
            searchParameters[key] = value;
        }
        
        public List<Books.BookItems> search(string q)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(BuildQuery(q));
                Books.Header bookList = JsonConvert.DeserializeObject<Books.Header>(json);
                return bookList.items;
            }
        }
    }
}
