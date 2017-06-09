using MediaObjectLibrary.Books;
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

namespace DesktopMediaTracker.Panel
{
    /// <summary>
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : UserControl
    {
        public BookItems Item { get; set; }
        public BookView(BookItems b)
        {
            InitializeComponent();
            this.Item = b;
            BookInfo bi = b.volumeInfo;
            uxTitle.Content = IsNull(bi.title);
            if (bi.subtitle != null)
                uxTitle.Content += ":" + bi.subtitle;
            if (bi.imageLinks != null)
            {
                if (bi.imageLinks.smallThumbnail != null)
                {
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(bi.imageLinks.smallThumbnail, UriKind.RelativeOrAbsolute);
                    src.CacheOption = BitmapCacheOption.OnLoad;
                    src.EndInit();
                    uxCover.Source = src;
                }
                else
                {
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri("Pictures\\NoCover.png", UriKind.RelativeOrAbsolute);
                    src.CacheOption = BitmapCacheOption.OnLoad;
                    src.EndInit();
                    uxCover.Source = src;
                }
            }
            else
            {
                BitmapImage src = new BitmapImage();
                src.BeginInit();
                src.UriSource = new Uri("Pictures\\NoCover.png", UriKind.RelativeOrAbsolute);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.EndInit();
                uxCover.Source = src;
            }
            uxAuthor.Content = IsNull(bi.authors);
            uxGenre.Content += IsNull(bi.categories);
            uxPageNumber.Content += IsNull(bi.pageCount.ToString());
            uxDiscription.Text = IsNull(bi.description);
        }
        private string IsNull(string s)
        {
            if (s == null)
                return "NA";
            else
                return s;
        }

        private string IsNull(List<string> s)
        {
            if (s == null)
                return "NA";
            else
            {
                string ret = "";
                foreach (string value in s)
                {
                    ret += value + ",";
                }
                ret = ret.Remove(ret.Count() - 1);
                return ret;
            }
        }
        private void uxViewButton_Click(object sender, RoutedEventArgs e)
        {

            Pages.BookSearchPage page = (Pages.BookSearchPage)this.Tag;
            page.NavigationService.Navigate(new BookDetailedPage(Item));
            
            
        }
    }
}
