using MediaObjectLibrary.Managers;
using MediaObjectLibrary.OMDB;
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
using System.Windows.Shapes;


namespace DesktopMediaTracker
{
    /// <summary>
    /// Interaction logic for MovieWindow.xaml
    /// </summary>
    public partial class MovieWindow : Window
    {
        public MovieWindow(string id)
        {
            InitializeComponent();
            InitializeData(id);
        }

        private void InitializeData(string id)
        {
            OmdbMovie data = MediaObjectFactory.GetMovieItemInformation(id);
            uxTitle.Content = data.Title;
            uxPlotBlock.Text = data.Plot;
            foreach (string s in data.Actors.Split(','))
            {
                uxActorListBox.Items.Add(s);
            }

            foreach (string s in data.Genre.Split(','))
            {
                uxGenreListBox.Items.Add(s);
            }
            uxDirectorLabel.Content += data.Director;
            uxYear.Content += data.Released;
            uxRating.Content += data.Rated;
            uxLangaugeLabel.Content += data.Language;
            uxRuntimeLabel.Content += data.Runtime;

        }
    }
}
