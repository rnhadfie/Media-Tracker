using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UserMediaDataLibrary.DataManipulation
{
  
    public class UpdateDataTable
    {
        static BookData bddb =new BookData();
        private static string path = System.Environment.CurrentDirectory.Remove(75) + "UserMediaDataLibrary\\Xml\\BookData.xml";
        private static UpdateDataTable instance = new UpdateDataTable();
        private UpdateDataTable()
        {
            bddb.ReadXml(path);
        }
        public static UpdateDataTable GetSingle()
        {
            return instance;
        }

        public static void UpdateGenreTable(string value)
        {
            DataTable genreTable = bddb.Tables["Genre"];
            bool doesNotExist = true;
            foreach (DataRow r in genreTable.Rows)
            {
                if (((string)r.ItemArray[0]).Equals(value)) {
                    doesNotExist = false;
                    break;
                } 
            }
            if (doesNotExist)
            {
                DataRow newRow = genreTable.NewRow();
                newRow["Genre"] = value;
                genreTable.Rows.Add(newRow);
                genreTable.AcceptChanges();
            }

        }

        public static void UpdateBooksTable(string isbn, string title, string author, string status)
        {
            DataTable booksTable = bddb.Tables["Books"];
            bool doesNotExist = true;
            foreach (DataRow r in booksTable.Rows)
            {
                if (((string)r.ItemArray[0]).Equals(isbn))
                {
                    doesNotExist = false;
                    break;
                }
            }
            if (doesNotExist)
            {
                DataRow newRow = booksTable.NewRow();
                newRow["ISBN"] = isbn;
                newRow["Title"] = title;
                newRow["Author"]= author;
                newRow["ReadingStatus"] = status;

                booksTable.Rows.Add(newRow);
                booksTable.AcceptChanges();
            }
        }
        public static void UpdateBooksTable(string isbn, string status)
        {
            DataTable booksTable = bddb.Tables["Books"];
            int index = 0;
            foreach (DataRow r in booksTable.Rows)
            {
                if (((string)r.ItemArray[0]).Equals(isbn))
                {
                    break;
                }
                index++;
            }
            DataRow row = booksTable.Rows[index];
            row["ReadingStatus"] = status;

            booksTable.AcceptChanges();
        }

        public static void UpdateBookGenreTable(string isbn, string genre)
        {
            DataTable bookGenreTable = bddb.Tables["Book_Genres"];
            bool doesNotExist = true;
            foreach (DataRow r in bookGenreTable.Rows)
            {
                if (((string)r.ItemArray[0]).Equals(isbn) && ((string)r.ItemArray[1]).Equals(genre))
                {
                    doesNotExist = false;
                    break;
                }
                
            }
            if (doesNotExist)
            {
                DataRow row = bookGenreTable.NewRow();
                row["BookISBN"] = isbn;
                row["Genre"] = genre;
                bookGenreTable.Rows.Add(row);

                bookGenreTable.AcceptChanges();
            }
        }

        public static void RemoveBook(string isbn)
        {
            DataTable bookGenreTable = bddb.Tables["Book_Genres"];
            DataTable bookTable = bddb.Tables["Books"];
           
            foreach (DataRow r in bookGenreTable.Rows)
            {
                if (((string)r.ItemArray[0]).Equals(isbn))
                {
                    bookGenreTable.Rows.Remove(r);
                }
                
            }
            bookGenreTable.AcceptChanges();

            foreach (DataRow r in bookTable.Rows)
            {
                if (((string)r.ItemArray[0]).Equals(isbn))
                {
                    bookTable.Rows.Remove(r);
                }

            }
            bookTable.AcceptChanges();
        }

        public static DataTable GetListOfBooks()
        {
            DataTable books=
            return null;
        }

    }
}
