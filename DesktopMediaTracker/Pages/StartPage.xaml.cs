using MediaObjects;
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
using OmdbRest;
using imdbAPI;

namespace DesktopMediaTracker.Pages
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();

          

        }
        private void uxViewYourMedia_Click(object sender, RoutedEventArgs e)
        {
           
            


        }

        private void uxMediaMovies_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SingleMediaSearchPage("Movie"));
        }

        private void uxMediaGraphicNovel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SingleMediaSearchPage("Graphic Novel"));
        }

        private void uxMediaNovels_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SingleMediaSearchPage("Novel"));
        }

        private void uxMediaTvShows_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SingleMediaSearchPage("Tv Show"));
        }

        private void uxMediaMusic_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SingleMediaSearchPage("Music"));
        }

        private void uxSearchButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MultiMediaSearchPage());

        }
    }
}
