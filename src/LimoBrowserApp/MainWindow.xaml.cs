using System;
using System.Collections.Generic;
using System.IO;
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
            LoadFiles();
        }

        public void AddTabToTabControl(object sender, RoutedEventArgs e)
        {
            TabItem newtab = new TabItem();
            InnitNewTab tab = new InnitNewTab();
            newtab.Content = tab;
            newtab.Style = (Style)FindResource("tabStyle");
            tabs.Items.Add(newtab);
            tabs.SelectedIndex = tabs.SelectedIndex + 1;
        }

        public void TransparentAddTabButton(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Background = Brushes.Transparent;
            ((Button)sender).BorderBrush = Brushes.Transparent;
        }

        public void LoadFiles()
        {
            string name = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development";
            switch (Directory.Exists(name))
            {
                case true:
                    string name2 = name + "\\LIMO-Browser";
                    switch (Directory.Exists(name2))
                    {
                        case true:
                            string name3 = name2 + "\\settings";
                            switch (Directory.Exists(name3))
                            {
                                case true:
                                    string name4 = name3 + "\\Themes.limobrowsertheme";
                                    switch (File.Exists(name4))
                                    {
                                        case true:
                                            ParseThemeFile();
                                            break;

                                        case false:
                                            File.Create(name4);
                                            break;
                                    }
                                    break;

                                case false:
                                    Directory.CreateDirectory(name3);
                                    break;
                            }
                            break;

                        case false:
                            Directory.CreateDirectory(name2);
                            break;
                    }
                    break;

                case false:
                    Directory.CreateDirectory(name);
                    break;
            }
        }

        public void ParseThemeFile()
        {
            string file = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme";
            foreach (string line in File.ReadAllLines(file))
            {
                switch (line)
                {
                    case "theme:red;":
                        allControls.Background = Brushes.DarkRed;
                        tabs.Background = Brushes.DarkRed;
                        break;

                    case "theme:orange;":
                        allControls.Background = Brushes.DarkOrange;
                        tabs.Background = Brushes.DarkOrange;
                        break;

                    case "theme:yellow;":
                        allControls.Background = Brushes.Gold;
                        tabs.Background = Brushes.Gold;
                        break;

                    case "theme:yellowgreen;":
                        allControls.Background = Brushes.YellowGreen;
                        tabs.Background = Brushes.YellowGreen;
                        break;

                    case "theme:green;":
                        allControls.Background = Brushes.DarkGreen;
                        tabs.Background = Brushes.DarkGreen;
                        break;


                    case "theme:aquamarine;":
                        allControls.Background = Brushes.CadetBlue;
                        tabs.Background = Brushes.CadetBlue;
                        break;

                    case "theme:cyan;":
                        allControls.Background = Brushes.DarkCyan;
                        tabs.Background = Brushes.DarkCyan;
                        break;

                    case "theme:lightblue;":
                        allControls.Background = Brushes.LightSkyBlue;
                        tabs.Background = Brushes.LightSkyBlue;
                        break;

                    case "theme:blue;":
                        allControls.Background = Brushes.DarkBlue;
                        tabs.Background = Brushes.DarkBlue;
                        break;

                    case "theme:purple;":
                        allControls.Background = Brushes.Purple;
                        tabs.Background = Brushes.Purple;
                        break;

                    case "theme:pink;":
                        allControls.Background = Brushes.Plum;
                        tabs.Background = Brushes.Plum;
                        break;
                }
            }
        }
    }
}
