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
            var x = Client.GetByTitle(itemTitle);
            
        }
    }
}
