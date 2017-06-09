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

namespace DesktopMediaTracker.Pages
{
    /// <summary>
    /// Interaction logic for BookStartPage.xaml
    /// </summary>
    public partial class BookStartPage : Page
    {
        public BookStartPage()
        {
            InitializeComponent();
        }

        private void uxSearch_Click(object sender, RoutedEventArgs e)
        {
            if(uxKeywordsText.Text.Equals("") && uxKeywordsText.Text.Equals("") && !comboBox.Text.Equals("All"))
                this.NavigationService.Navigate(new BookSearchPage());
            else
                this.NavigationService.Navigate(new BookSearchPage(uxKeywordsText.Text, uxAuthorText.Text, comboBox.Text));
        }
    }
}
