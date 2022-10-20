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
    /// Interakční logika pro InnitNewTab.xaml
    /// </summary>
    public partial class InnitNewTab : UserControl
    {
        public InnitNewTab()
        {
            InitializeComponent();
            SetupElemsFromXAML();
        }

        public void SetupElemsFromXAML()
        {
            navbar.Width = SystemParameters.PrimaryScreenWidth;
            navbar.Height = 30;
            def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
            www.Height = (SystemParameters.PrimaryScreenHeight - 60) - 105;
            def1.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 130);
            urlbar.Width = SystemParameters.PrimaryScreenWidth - 90;
        }

        public void LoadCefSharpWebPage(object sender, RoutedEventArgs e)
        {
            if (urlbar.Text != null)
            {
                if (urlbar.Text.Contains(".") && !urlbar.Text.Contains(" "))
                {
                    www.Load("https://" + urlbar.Text);
                } else
                {
                    www.Load("https://www.google.com/search?q=" + urlbar.Text);
                }
            }
        }
        
        public bool settingsShown = false;

        public void ToggleSettings(object sender, RoutedEventArgs e)
        {
            switch (settingsShown)
            {
                case true:
                    browserGrid.ColumnDefinitions.RemoveAt(2);
                    browserGrid.Children.RemoveAt(2);
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
                    settingsShown = false;
                    break;

                case false:
                    // columns
                    ColumnDefinition settingsdef = new ColumnDefinition();
                    settingsdef.Width = new GridLength(100);
                    browserGrid.ColumnDefinitions.Add(settingsdef);

                    // initializer
                    StackPanel settingspanel = new StackPanel();
                    settingspanel.Background = Brushes.DarkRed;

                    // adder
                    browserGrid.Children.Add(settingspanel);

                    // setter
                    Grid.SetColumn(settingspanel, 2);
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 130);
                    settingsShown = true;
                    break;
            }
        }
    }
}
