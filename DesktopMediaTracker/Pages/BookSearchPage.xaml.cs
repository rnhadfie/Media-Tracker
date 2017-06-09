using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MediaObjectLibrary.Managers;
using MediaObjectLibrary.Books;

namespace DesktopMediaTracker.Pages
{
    /// <summary>
    /// Interaction logic for BookSearchPage.xaml
    /// </summary>
    public partial class BookSearchPage : Page
    {
        private List<BookItems> totalListofBooks=new List<BookItems>();
        public BookSearchPage()
        {
            InitializeComponent();
        }

        public BookSearchPage(string keyword, string author, string type)
        {
            InitializeComponent();
            BookManager bm = new BookManager();
            if (((int)author.Count()) > 0)
                bm.UpdateHashTable("inauthor", author.Replace(' ','+'));
            //if (!type.Equals("all"))
               // bm.UpdateHashTable("printType", type);
            string q=keyword.Replace(" ", "+");
            totalListofBooks= bm.search(q);
            LoadSearchPage();
        }

        private void LoadSearchPage()
        {
            
            for (int i = 0; i < 5 && i<totalListofBooks.Count; i++)
            {
                BookInfo bi = totalListofBooks.ElementAt(i).volumeInfo;
                Panel.BookView bv = new Panel.BookView(totalListofBooks.ElementAt(i));
                bv.Tag = this;
                uxInformPanel.Children.Add(bv);
                
            }
        }
        

        private void RowDefinition_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        
    }
}
