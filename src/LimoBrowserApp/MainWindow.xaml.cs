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

namespace LimoBrowserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void AddTabToTabControl(object sender, RoutedEventArgs e)
        {
            TabItem newtab = new TabItem();
            InnitNewTab tab = new InnitNewTab();
            newtab.Content = tab;
            newtab.Style = (Style)FindResource("tabStyle");
            tabs.Items.Add(newtab);
        }

        public void TransparentAddTabButton(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Background = Brushes.Transparent;
            ((Button)sender).BorderBrush = Brushes.Transparent;
        }
    }
}
