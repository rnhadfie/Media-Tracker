﻿using System;
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
    /// Interaction logic for MoviePanel.xaml
    /// </summary>
    public partial class MoviePanel : UserControl
    {
        public string ItemId { get; set; }
        public MoviePanel()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MovieWindow mw = new MovieWindow(this.ItemId);
            mw.Show();
        }
    }
}