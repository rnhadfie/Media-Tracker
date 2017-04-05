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
            

            string url = "http://www.omdbapi.com/?s=" + itemTitle.Trim();
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                var jsonist = json.Split('[')[1];
                jsonist = "["+json.Split(']')[0]+"]";
   
                var result = JsonConvert.DeserializeObject<List<ImdbObj>>(jsonist);

               
               


            }
        }

    }
    
}
