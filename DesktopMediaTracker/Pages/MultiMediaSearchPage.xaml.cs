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
        private int TotalNumberOfPages;
        private string item;
        public MultiMediaSearchPage()
        {
            InitializeComponent();
            HideSearchButtons(MediaObjectFactory.PageTotal);
        }
        public MultiMediaSearchPage(string s)
        {
            InitializeComponent();
            SearchLogic(s);
            HideSearchButtons(MediaObjectFactory.PageTotal);
            item = s;
        }

        private void uxSearchButton_Click(object sender, RoutedEventArgs e)
        {
            item = uxSearchText.Text;
            SearchLogic (uxSearchText.Text);
            HideSearchButtons(TotalNumberOfPages);

        }
        private void SearchLogic(string itemTitle)
        {
           
            List<OmdbSearch> list = MediaObjectFactory.Search(itemTitle);
            TotalNumberOfPages = MediaObjectFactory.PageTotal;
            int n = 0;
            uxDisplayGrid.Children.Clear();
            for (int i = 0; i < 5 && n < list.Count; i++)
            {
                for (int j = 0; j < 2 && n < list.Count; j++)
                {
                    Panel.MoviePanel temp = new Panel.MoviePanel();
                    temp.uxTitle.Content = list[n].Title;
                    temp.uxYear.Content = list[n].Year;
                    temp.uxSeries.Content = list[n].Type;
                    temp.ItemId = list[n].imdbID;
                    Grid.SetRow(temp, i);
                    Grid.SetColumn(temp, j);
                    uxDisplayGrid.Children.Add(temp);
                    n++;
                }
            }
        }

        private void SearchLogic(string itemTitle, int page)
        {
            TotalNumberOfPages = MediaObjectFactory.PageTotal;
            List<OmdbSearch> list = MediaObjectFactory.Search(itemTitle,page);
            int n = 0;
            uxDisplayGrid.Children.Clear();
            for (int i = 0; i < 5 && n < list.Count; i++)
            {
                for (int j = 0; j < 2 && n < list.Count; j++)
                {
                    Panel.MoviePanel temp = new Panel.MoviePanel();
                    temp.uxTitle.Content = list[n].Title;
                    temp.uxYear.Content = list[n].Year;
                    temp.uxSeries.Content = list[n].Type;
                    temp.ItemId = list[n].imdbID;
                    Grid.SetRow(temp, i);
                    Grid.SetColumn(temp, j);
                    uxDisplayGrid.Children.Add(temp);
                    n++;
                }
            }
        }

        private void uxFirst_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NumberReset(uxFirst.Content.ToString());
            SearchLogic(item, 1);
        }

        private void NumberReset(string labelText)
        {
           
            if (labelText.Equals("First"))
            {
                uxFirst.Content = "1, ";
                uxNext.Content = "2, ";
                uxNext2.Content = "3, ";
                uxNext3.Content = "4, ";
            }
            else if (labelText.Equals("Last"))
            {
                if (TotalNumberOfPages > 4)
                {
                    uxNext3.Content = (TotalNumberOfPages - 1).ToString() + ", ";
                    uxNext2.Content = (TotalNumberOfPages - 2).ToString() + ", ";
                    uxNext.Content = (TotalNumberOfPages - 3).ToString() + ", ";
                    uxFirst.Content = "First";
                }
            }
            else
            {
                if((TotalNumberOfPages-2)> int.Parse(labelText[0].ToString()))
                uxFirst.Content = "First";
                uxNext.Content = labelText;
                uxNext.Content = (int.Parse(labelText[0].ToString()) + 2).ToString() + ", ";
                uxNext2.Content = (int.Parse(labelText[0].ToString()) + 3).ToString() + ", ";
                
            }
        }

        private void uxNext_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            SearchLogic(item, Int32.Parse(uxNext.Content.ToString()[0].ToString()));
            NumberReset(uxNext.Content.ToString());
        }

        private void uxNext2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NumberReset(uxNext2.Content.ToString());
            SearchLogic(item, Int32.Parse(uxNext.Content.ToString()[0].ToString()));
        }

        private void uxNext3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NumberReset(uxNext3.Content.ToString());
            SearchLogic(item, Int32.Parse(uxNext.Content.ToString()[0].ToString()));
        }

        private void uxLast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NumberReset(uxLast.Content.ToString());
            SearchLogic(item, TotalNumberOfPages);
        }
        private void HideSearchButtons(int pages)
        {
            switch(pages)
            {
                case 0:  
                case 1: {
                        uxPageStackPanel.Visibility = Visibility.Hidden;
                        break;
                        }
                case 2: {
                        uxPageStackPanel.Visibility = Visibility.Visible;
                        uxNext.Visibility = Visibility.Hidden;
                        uxNext2.Visibility = Visibility.Hidden;
                        uxNext3.Visibility = Visibility.Hidden;
                        break;
                        }
                case 3: {
                        uxPageStackPanel.Visibility = Visibility.Visible;
                        uxNext.Visibility = Visibility.Visible;
                        uxNext2.Visibility = Visibility.Hidden;
                        uxNext3.Visibility = Visibility.Hidden;
                        break;
                        }
                case 4:
                        {
                        uxPageStackPanel.Visibility = Visibility.Visible;
                        uxNext.Visibility = Visibility.Visible;
                        uxNext2.Visibility = Visibility.Visible;
                        uxNext3.Visibility = Visibility.Hidden;
                        break;
                    }
                default:
                    {
                        uxPageStackPanel.Visibility = Visibility.Visible;
                        uxNext.Visibility = Visibility.Visible;
                        uxNext2.Visibility = Visibility.Visible;
                        uxNext3.Visibility = Visibility.Visible;
                        break;
                    }
            }
        }
    } 
}
