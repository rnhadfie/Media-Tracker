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
using Omdb.Net.RequestBuilder;
using System.Net;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using MediaObjectLibrary.OMDB;
using MediaObjectLibrary.Managers;

namespace DesktopMediaTracker.Pages
{
    /// <summary>
    /// Interaction logic for MultiMediaSearchPage.xaml
    /// </summary>
    public partial class MultiMediaSearchPage : Page
    {
        public MultiMediaSearchPage()
        {
            InitializeComponent();
        }

        private void uxSearchButton_Click(object sender, RoutedEventArgs e)
        {
            string itemTitle = uxSearchText.Text;
            List<OmdbSearch> list= MediaObjectFactory.Search(itemTitle);
            int n = 0;
            uxDisplayGrid.Children.Clear();
            for (int i = 0; i < 5 && n<list.Count; i++)
            {
               for (int j = 0; j < 2 && n < list.Count; j++)
                {
                    Panel.MoviePanel temp= new Panel.MoviePanel();
                    temp.uxTitle.Content = list[n].Title;
                    temp.uxYear.Content= list[n].Year;
                    temp.uxSeries.Content= list[n].Type;
                    temp.ItemId = list[n].imdbID;
                    Grid.SetRow(temp, i);
                    Grid.SetColumn(temp, j);
                    uxDisplayGrid.Children.Add(temp);
                    n++;
                }
            }
        }
  } 
}
