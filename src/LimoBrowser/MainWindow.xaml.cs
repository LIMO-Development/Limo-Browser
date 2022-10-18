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

namespace LimoBrowser
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int leftmargin = 0;

        public MainWindow()
        {
            InitializeComponent();
            addbtn.Margin = new Thickness(leftmargin, 0, 0, 0);
        }
        public void AddTabToTabcontrol(object sender, RoutedEventArgs e)
        {
            TabItem newtab = new TabItem();
            TabWindow tab = new TabWindow();
            newtab.Content = tab;
            newtab.Header = "New tab";
            newtab.Style = (Style)FindResource("tabStyle");
            tabs.Items.Add(newtab);
            leftmargin += 150;
        }

        public void HoverBackgroundOn(object sender, RoutedEventArgs e)
        {
            addbtn.Style = (Style)FindResource("addtabHoverStyle");
        }

        public void HoverBackgroundOff(object sender, RoutedEventArgs e)
        {
            addbtn.Style = (Style)FindResource("addtabStyle");
        }
    }
}
