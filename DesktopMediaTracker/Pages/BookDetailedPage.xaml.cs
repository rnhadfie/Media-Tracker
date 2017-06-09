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
using MediaObjectLibrary.Books;

namespace DesktopMediaTracker
{
    /// <summary>
    /// Interaction logic for BookDetailedPage.xaml
    /// </summary>
    public partial class BookDetailedPage : Page
    {
        public BookItems Book { get; set; }
        public BookDetailedPage(BookItems book)
        {
            InitializeComponent();
            this.Book = book;
            BookInfo volumeInfo = book.volumeInfo;
            loadData(volumeInfo);
            
        }
        private void loadImage(BookInfo bi)
        {
            if (bi.imageLinks != null)
            {
                if (bi.imageLinks.thumbnail != null)
                {
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(bi.imageLinks.thumbnail, UriKind.RelativeOrAbsolute);
                    src.CacheOption = BitmapCacheOption.OnLoad;
                    src.EndInit();
                    uxCoverImage.Source = src;
                }
                else
                {
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri("Pictures\\NoCover.png", UriKind.RelativeOrAbsolute);
                    src.CacheOption = BitmapCacheOption.OnLoad;
                    src.EndInit();
                    uxCoverImage.Source = src;
                }
            }
            else
            {
                BitmapImage src = new BitmapImage();
                src.BeginInit();
                src.UriSource = new Uri("Pictures\\NoCover.png", UriKind.RelativeOrAbsolute);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.EndInit();
                uxCoverImage.Source = src;
            }
        }
        private void loadData(BookInfo info)
        {
            uxTitle.Content = info.title;
            if (info.subtitle != null)
                uxTitle.Content += ":" + info.subtitle;
            uxAuthor.Content = ReplaceNull(info.authors);
            uxPublisher.Content = ReplaceNull(info.publisher);
            uxPublishDate.Content = ReplaceNull(info.publishedDate);
            uxDescriptionBlock.Text = ReplaceNull(info.description);
            uxLanguage.Content = ReplaceNull(info.language);
            uxCategory.Content = ReplaceNull(info.categories);
            uxMaturity.Content = ReplaceNull(info.maturityRating);
            loadImage(info);
        }

        private string ReplaceNull(string s) {
            if (s == null)
                return "NA";
            else
                return s;
        }
        private string ReplaceNull(List<string> s)
        {
            if (s == null || s.Count==0)
                return "NA";
            else
            {
                string values = "";
                foreach (string value in s)
                {
                    values += value + ",";
                }
                return values.Remove(values.Count() - 1);
            }
        }
    }
}
