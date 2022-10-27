using CefSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            ParseThemeFile();
        }

        public void SetupElemsFromXAML()
        {
            navbar.Width = SystemParameters.PrimaryScreenWidth;
            navbar.Height = 30;
            def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
            www.Height = (SystemParameters.PrimaryScreenHeight - 60) - 105;
            def1.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 260);
            urlbar.Width = SystemParameters.PrimaryScreenWidth - 275;
        }

        public void LoadCefSharpWebPage(object sender, RoutedEventArgs e)
        {
            if (urlbar.Text != null)
            {
                if (urlbar.Text == "limob://newtab")
                {
                    www.Load("https://limodevelopmentcom.ferder.repl.co/limobnewtab");
                }
                else if (urlbar.Text.Contains(".") && !urlbar.Text.Contains(" "))
                {
                    www.Load("https://" + urlbar.Text);
                }
                else
                {
                    www.Load("https://www.google.com/search?q=" + urlbar.Text);
                }
            }
        }

        public void GoBackInBrowser(object sender, RoutedEventArgs e)
        {
            switch (www.CanGoBack)
            {
                case true:
                    www.Back();
                    break;

                case false:
                    break;
            }
        }

        public void GoForwardInBrowser(object sender, RoutedEventArgs e)
        {
            switch (www.CanGoForward)
            {
                case true:
                    www.Forward();
                    break;

                case false:
                    break;
            }
        }
        
        public bool settingsShown = false;

        public void ToggleSettings(object sender, RoutedEventArgs e)
        {
            switch (settingsShown)
            {
                case true:
                    browserGrid.ColumnDefinitions.RemoveAt(3);
                    browserGrid.Children.RemoveAt(3);
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
                    settingsShown = false;
                    break;

                case false:
                    // columns
                    ColumnDefinition settingsdef = new ColumnDefinition();
                    settingsdef.Width = new GridLength(300);
                    browserGrid.ColumnDefinitions.Add(settingsdef);

                    // initializer
                    StackPanel settingspanel = new StackPanel();
                    settingspanel.Background = Brushes.DimGray;

                    // options
                    Button button1 = new Button();
                    TextBlock label1 = new TextBlock();
                    label1.Text = "Open WebApp mode";
                    button1.Content = label1;

                    // adders
                    settingspanel.Children.Add(button1);
                    browserGrid.Children.Add(settingspanel);

                    // setters
                    Grid.SetColumn(settingspanel, 3);
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 330);
                    settingsShown = true;
                    break;
            }
        }

        public bool appwidgetshown = false;

        public void ToggleYoutubeWidget(object sender, RoutedEventArgs e)
        {
            switch (appwidgetshown)
            {
                case true:
                    appWidgetDef.Width = new GridLength(0);
                    appWidget.Width = 0;
                    appWidgetNavbar.Width = 0;
                    appWidgetWebview.Width = 0;
                    appWidgetWebview.Height = 0;
                    appWidgetWebview.Address = "";
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
                    appwidgetshown = false;
                    break;

                case false:
                    switch (settingsShown)
                    {
                        case true:
                            break;

                        case false:
                            appWidgetDef.Width = new GridLength((SystemParameters.PrimaryScreenWidth / 2) - 30);
                            appWidget.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetNavbar.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Height = (SystemParameters.PrimaryScreenHeight - 30) - 105;
                            appWidgetWebview.Address = "https://www.youtube.com";
                            def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - ((SystemParameters.PrimaryScreenWidth / 2) + 30));
                            appwidgetshown = true;
                            break;
                    }
                    break;
            }
        }

        public void ToggleTiktokWidget(object sender, RoutedEventArgs e)
        {
            switch (appwidgetshown)
            {
                case true:
                    appWidgetDef.Width = new GridLength(0);
                    appWidget.Width = 0;
                    appWidgetNavbar.Width = 0;
                    appWidgetWebview.Width = 0;
                    appWidgetWebview.Height = 0;
                    appWidgetWebview.Address = "";
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
                    appwidgetshown = false;
                    break;

                case false:
                    switch (settingsShown)
                    {
                        case true:
                            break;

                        case false:
                            appWidgetDef.Width = new GridLength((SystemParameters.PrimaryScreenWidth / 2) - 30);
                            appWidget.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetNavbar.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Height = (SystemParameters.PrimaryScreenHeight - 30) - 105;
                            appWidgetWebview.Address = "https://www.tiktok.com";
                            def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - ((SystemParameters.PrimaryScreenWidth / 2) + 30));
                            appwidgetshown = true;
                            break;
                    }
                    break;
            }
        }

        public void ToggleDiscordWidget(object sender, RoutedEventArgs e)
        {
            switch (appwidgetshown)
            {
                case true:
                    appWidgetDef.Width = new GridLength(0);
                    appWidget.Width = 0;
                    appWidgetNavbar.Width = 0;
                    appWidgetWebview.Width = 0;
                    appWidgetWebview.Height = 0;
                    appWidgetWebview.Address = "";
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
                    appwidgetshown = false;
                    break;

                case false:
                    switch (settingsShown)
                    {
                        case true:
                            break;

                        case false:
                            appWidgetDef.Width = new GridLength((SystemParameters.PrimaryScreenWidth / 2) - 30);
                            appWidget.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetNavbar.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Height = (SystemParameters.PrimaryScreenHeight - 30) - 105;
                            appWidgetWebview.Address = "https://www.discord.com/app";
                            def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - ((SystemParameters.PrimaryScreenWidth / 2) + 30));
                            appwidgetshown = true;
                            break;
                    }
                    break;
            }
        }

        public void ToggleInstagramWidget(object sender, RoutedEventArgs e)
        {
            switch (appwidgetshown)
            {
                case true:
                    appWidgetDef.Width = new GridLength(0);
                    appWidget.Width = 0;
                    appWidgetNavbar.Width = 0;
                    appWidgetWebview.Width = 0;
                    appWidgetWebview.Height = 0;
                    appWidgetWebview.Address = "";
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
                    appwidgetshown = false;
                    break;

                case false:
                    switch (settingsShown)
                    {
                        case true:
                            break;

                        case false:
                            appWidgetDef.Width = new GridLength((SystemParameters.PrimaryScreenWidth / 2) - 30);
                            appWidget.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetNavbar.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Height = (SystemParameters.PrimaryScreenHeight - 30) - 105;
                            appWidgetWebview.Address = "https://www.instagram.com";
                            def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - ((SystemParameters.PrimaryScreenWidth / 2) + 30));
                            appwidgetshown = true;
                            break;
                    }
                    break;
            }
        }

        public void ToggleTwitterWidget(object sender, RoutedEventArgs e)
        {
            switch (appwidgetshown)
            {
                case true:
                    appWidgetDef.Width = new GridLength(0);
                    appWidget.Width = 0;
                    appWidgetNavbar.Width = 0;
                    appWidgetWebview.Width = 0;
                    appWidgetWebview.Height = 0;
                    appWidgetWebview.Address = "";
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
                    appwidgetshown = false;
                    break;

                case false:
                    switch (settingsShown)
                    {
                        case true:
                            break;

                        case false:
                            appWidgetDef.Width = new GridLength((SystemParameters.PrimaryScreenWidth / 2) - 30);
                            appWidget.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetNavbar.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Height = (SystemParameters.PrimaryScreenHeight - 30) - 105;
                            appWidgetWebview.Address = "https://www.twitter.com";
                            def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - ((SystemParameters.PrimaryScreenWidth / 2) + 30));
                            appwidgetshown = true;
                            break;
                    }
                    break;
            }
        }

        public void ToggleSpotifyWidget(object sender, RoutedEventArgs e)
        {
            switch (appwidgetshown)
            {
                case true:
                    appWidgetDef.Width = new GridLength(0);
                    appWidget.Width = 0;
                    appWidgetNavbar.Width = 0;
                    appWidgetWebview.Width = 0;
                    appWidgetWebview.Height = 0;
                    appWidgetWebview.Address = "";
                    def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 30);
                    appwidgetshown = false;
                    break;

                case false:
                    switch (settingsShown)
                    {
                        case true:
                            break;

                        case false:
                            appWidgetDef.Width = new GridLength((SystemParameters.PrimaryScreenWidth / 2) - 30);
                            appWidget.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetNavbar.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Width = (SystemParameters.PrimaryScreenWidth / 2) - 30;
                            appWidgetWebview.Height = (SystemParameters.PrimaryScreenHeight - 30) - 105;
                            appWidgetWebview.Address = "https://open.spotify.com";
                            def2.Width = new GridLength(SystemParameters.PrimaryScreenWidth - ((SystemParameters.PrimaryScreenWidth / 2) + 30));
                            appwidgetshown = true;
                            break;
                    }
                    break;
            }
        }

        public void ParseThemeFile()
        {
            string file = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme";
            switch (System.IO.File.Exists(file))
            {
                case true:
                    foreach (string line in System.IO.File.ReadAllLines(file))
                    {
                        switch (line)
                        {
                            case "theme:red;":
                                navbar.Background = Brushes.DarkRed;
                                urlbar.Background = Brushes.Red;
                                urlbar.BorderBrush = Brushes.Red;
                                sidebar.Background = Brushes.DarkRed;
                                goButton.Background = Brushes.Red;
                                goButton.BorderBrush = Brushes.Red;
                                backButton.Background = Brushes.Red;
                                backButton.BorderBrush = Brushes.Red;
                                forwardButton.Background = Brushes.Red;
                                forwardButton.BorderBrush = Brushes.Red;
                                settingsButton.Background = Brushes.Red;
                                settingsButton.BorderBrush = Brushes.Red;
                                break;

                            case "theme:orange;":
                                navbar.Background = Brushes.DarkOrange;
                                urlbar.Background = Brushes.Orange;
                                urlbar.BorderBrush = Brushes.Orange;
                                sidebar.Background = Brushes.DarkOrange;
                                goButton.Background = Brushes.Orange;
                                goButton.BorderBrush = Brushes.Orange;
                                backButton.Background = Brushes.Orange;
                                backButton.BorderBrush = Brushes.Orange;
                                forwardButton.Background = Brushes.Orange;
                                forwardButton.BorderBrush = Brushes.Orange;
                                settingsButton.Background = Brushes.Orange;
                                settingsButton.BorderBrush = Brushes.Orange;
                                break;

                            case "theme:yellow;":
                                navbar.Background = Brushes.Gold;
                                urlbar.Background = Brushes.Yellow;
                                urlbar.BorderBrush = Brushes.Yellow;
                                sidebar.Background = Brushes.Gold;
                                goButton.Background = Brushes.Yellow;
                                goButton.BorderBrush = Brushes.Yellow;
                                backButton.Background = Brushes.Yellow;
                                backButton.BorderBrush = Brushes.Yellow;
                                forwardButton.Background = Brushes.Yellow;
                                forwardButton.BorderBrush = Brushes.Yellow;
                                settingsButton.Background = Brushes.Yellow;
                                settingsButton.BorderBrush = Brushes.Yellow;
                                break;

                            case "theme:yellowgreen;":
                                navbar.Background = Brushes.YellowGreen;
                                urlbar.Background = Brushes.GreenYellow;
                                urlbar.BorderBrush = Brushes.GreenYellow;
                                sidebar.Background = Brushes.YellowGreen;
                                goButton.Background = Brushes.GreenYellow;
                                goButton.BorderBrush = Brushes.GreenYellow;
                                backButton.Background = Brushes.GreenYellow;
                                backButton.BorderBrush = Brushes.GreenYellow;
                                forwardButton.Background = Brushes.GreenYellow;
                                forwardButton.BorderBrush = Brushes.GreenYellow;
                                settingsButton.Background = Brushes.GreenYellow;
                                settingsButton.BorderBrush = Brushes.GreenYellow;
                                break;

                            case "theme:green;":
                                navbar.Background = Brushes.DarkGreen;
                                urlbar.Background = Brushes.Lime;
                                urlbar.BorderBrush = Brushes.Lime;
                                sidebar.Background = Brushes.DarkGreen;
                                goButton.Background = Brushes.Lime;
                                goButton.BorderBrush = Brushes.Lime;
                                backButton.Background = Brushes.Lime;
                                backButton.BorderBrush = Brushes.Lime;
                                forwardButton.Background = Brushes.Lime;
                                forwardButton.BorderBrush = Brushes.Lime;
                                settingsButton.Background = Brushes.Lime;
                                settingsButton.BorderBrush = Brushes.Lime;
                                break;

                            case "theme:aquamarine;":
                                navbar.Background = Brushes.CadetBlue;
                                urlbar.Background = Brushes.Aquamarine;
                                urlbar.BorderBrush = Brushes.Aquamarine;
                                sidebar.Background = Brushes.CadetBlue;
                                goButton.Background = Brushes.Aquamarine;
                                goButton.BorderBrush = Brushes.Aquamarine;
                                backButton.Background = Brushes.Aquamarine;
                                backButton.BorderBrush = Brushes.Aquamarine;
                                forwardButton.Background = Brushes.Aquamarine;
                                forwardButton.BorderBrush = Brushes.Aquamarine;
                                settingsButton.Background = Brushes.Aquamarine;
                                settingsButton.BorderBrush = Brushes.Aquamarine;
                                break;

                            case "theme:cyan;":
                                navbar.Background = Brushes.DarkCyan;
                                urlbar.Background = Brushes.Cyan;
                                urlbar.BorderBrush = Brushes.Cyan;
                                sidebar.Background = Brushes.DarkCyan;
                                goButton.Background = Brushes.Cyan;
                                goButton.BorderBrush = Brushes.Cyan;
                                backButton.Background = Brushes.Cyan;
                                backButton.BorderBrush = Brushes.Cyan;
                                forwardButton.Background = Brushes.Cyan;
                                forwardButton.BorderBrush = Brushes.Cyan;
                                settingsButton.Background = Brushes.Cyan;
                                settingsButton.BorderBrush = Brushes.Cyan;
                                break;

                            case "theme:lightblue;":
                                navbar.Background = Brushes.LightSkyBlue;
                                urlbar.Background = Brushes.LightBlue;
                                urlbar.BorderBrush = Brushes.LightBlue;
                                sidebar.Background = Brushes.LightSkyBlue;
                                goButton.Background = Brushes.LightBlue;
                                goButton.BorderBrush = Brushes.LightBlue;
                                backButton.Background = Brushes.LightBlue;
                                backButton.BorderBrush = Brushes.LightBlue;
                                forwardButton.Background = Brushes.LightBlue;
                                forwardButton.BorderBrush = Brushes.LightBlue;
                                settingsButton.Background = Brushes.LightBlue;
                                settingsButton.BorderBrush = Brushes.LightBlue;
                                break;

                            case "theme:blue;":
                                navbar.Background = Brushes.DarkBlue;
                                urlbar.Background = Brushes.Blue;
                                urlbar.BorderBrush = Brushes.Blue;
                                sidebar.Background = Brushes.DarkBlue;
                                goButton.Background = Brushes.Blue;
                                goButton.BorderBrush = Brushes.Blue;
                                backButton.Background = Brushes.Blue;
                                backButton.BorderBrush = Brushes.Blue;
                                forwardButton.Background = Brushes.Blue;
                                forwardButton.BorderBrush = Brushes.Blue;
                                settingsButton.Background = Brushes.Blue;
                                settingsButton.BorderBrush = Brushes.Blue;
                                break;

                            case "theme:purple;":
                                navbar.Background = Brushes.Purple;
                                urlbar.Background = Brushes.DarkOrchid;
                                urlbar.BorderBrush = Brushes.DarkOrchid;
                                sidebar.Background = Brushes.Purple;
                                goButton.Background = Brushes.DarkOrchid;
                                goButton.BorderBrush = Brushes.DarkOrchid;
                                backButton.Background = Brushes.DarkOrchid;
                                backButton.BorderBrush = Brushes.DarkOrchid;
                                forwardButton.Background = Brushes.DarkOrchid;
                                forwardButton.BorderBrush = Brushes.DarkOrchid;
                                settingsButton.Background = Brushes.DarkOrchid;
                                settingsButton.BorderBrush = Brushes.DarkOrchid;
                                break;

                            case "theme:pink;":
                                navbar.Background = Brushes.HotPink;
                                urlbar.Background = Brushes.Violet;
                                urlbar.BorderBrush = Brushes.Violet;
                                sidebar.Background = Brushes.HotPink;
                                goButton.Background = Brushes.Violet;
                                goButton.BorderBrush = Brushes.Violet;
                                backButton.Background = Brushes.Violet;
                                backButton.BorderBrush = Brushes.Violet;
                                forwardButton.Background = Brushes.Violet;
                                forwardButton.BorderBrush = Brushes.Violet;
                                settingsButton.Background = Brushes.Violet;
                                settingsButton.BorderBrush = Brushes.Violet;
                                break;

                            // black background themes
                            case "theme:blackred;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Red;
                                urlbar.BorderBrush = Brushes.Red;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Red;
                                goButton.BorderBrush = Brushes.Red;
                                backButton.Background = Brushes.Red;
                                backButton.BorderBrush = Brushes.Red;
                                forwardButton.Background = Brushes.Red;
                                forwardButton.BorderBrush = Brushes.Red;
                                settingsButton.Background = Brushes.Red;
                                settingsButton.BorderBrush = Brushes.Red;
                                break;

                            case "theme:blackorange;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Orange;
                                urlbar.BorderBrush = Brushes.Orange;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Orange;
                                goButton.BorderBrush = Brushes.Orange;
                                backButton.Background = Brushes.Orange;
                                backButton.BorderBrush = Brushes.Orange;
                                forwardButton.Background = Brushes.Orange;
                                forwardButton.BorderBrush = Brushes.Orange;
                                settingsButton.Background = Brushes.Orange;
                                settingsButton.BorderBrush = Brushes.Orange;
                                break;

                            case "theme:blackyellow;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Yellow;
                                urlbar.BorderBrush = Brushes.Yellow;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Yellow;
                                goButton.BorderBrush = Brushes.Yellow;
                                backButton.Background = Brushes.Yellow;
                                backButton.BorderBrush = Brushes.Yellow;
                                forwardButton.Background = Brushes.Yellow;
                                forwardButton.BorderBrush = Brushes.Yellow;
                                settingsButton.Background = Brushes.Yellow;
                                settingsButton.BorderBrush = Brushes.Yellow;
                                break;

                            case "theme:blackyellowgreen;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.YellowGreen;
                                urlbar.BorderBrush = Brushes.YellowGreen;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.YellowGreen;
                                goButton.BorderBrush = Brushes.YellowGreen;
                                backButton.Background = Brushes.YellowGreen;
                                backButton.BorderBrush = Brushes.YellowGreen;
                                forwardButton.Background = Brushes.YellowGreen;
                                forwardButton.BorderBrush = Brushes.YellowGreen;
                                settingsButton.Background = Brushes.YellowGreen;
                                settingsButton.BorderBrush = Brushes.YellowGreen;
                                break;

                            case "theme:blackgreen;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Lime;
                                urlbar.BorderBrush = Brushes.Lime;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Lime;
                                goButton.BorderBrush = Brushes.Lime;
                                backButton.Background = Brushes.Lime;
                                backButton.BorderBrush = Brushes.Lime;
                                forwardButton.Background = Brushes.Lime;
                                forwardButton.BorderBrush = Brushes.Lime;
                                settingsButton.Background = Brushes.Lime;
                                settingsButton.BorderBrush = Brushes.Lime;
                                break;

                            case "theme:blackaquamarine;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Aquamarine;
                                urlbar.BorderBrush = Brushes.Aquamarine;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Aquamarine;
                                goButton.BorderBrush = Brushes.Aquamarine;
                                backButton.Background = Brushes.Aquamarine;
                                backButton.BorderBrush = Brushes.Aquamarine;
                                forwardButton.Background = Brushes.Aquamarine;
                                forwardButton.BorderBrush = Brushes.Aquamarine;
                                settingsButton.Background = Brushes.Aquamarine;
                                settingsButton.BorderBrush = Brushes.Aquamarine;
                                break;

                            case "theme:blackcyan;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Cyan;
                                urlbar.BorderBrush = Brushes.Cyan;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Cyan;
                                goButton.BorderBrush = Brushes.Cyan;
                                backButton.Background = Brushes.Cyan;
                                backButton.BorderBrush = Brushes.Cyan;
                                forwardButton.Background = Brushes.Cyan;
                                forwardButton.BorderBrush = Brushes.Cyan;
                                settingsButton.Background = Brushes.Cyan;
                                settingsButton.BorderBrush = Brushes.Cyan;
                                break;

                            case "theme:blacklightblue;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.LightBlue;
                                urlbar.BorderBrush = Brushes.LightBlue;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.LightBlue;
                                goButton.BorderBrush = Brushes.LightBlue;
                                backButton.Background = Brushes.LightBlue;
                                backButton.BorderBrush = Brushes.LightBlue;
                                forwardButton.Background = Brushes.LightBlue;
                                forwardButton.BorderBrush = Brushes.LightBlue;
                                settingsButton.Background = Brushes.LightBlue;
                                settingsButton.BorderBrush = Brushes.LightBlue;
                                break;

                            case "theme:blackblue;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Blue;
                                urlbar.BorderBrush = Brushes.Blue;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Blue;
                                goButton.BorderBrush = Brushes.Blue;
                                backButton.Background = Brushes.Blue;
                                backButton.BorderBrush = Brushes.Blue;
                                forwardButton.Background = Brushes.Blue;
                                forwardButton.BorderBrush = Brushes.Blue;
                                settingsButton.Background = Brushes.Blue;
                                settingsButton.BorderBrush = Brushes.Blue;
                                break;

                            case "theme:blackpurple;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Purple;
                                urlbar.BorderBrush = Brushes.Purple;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Purple;
                                goButton.BorderBrush = Brushes.Purple;
                                backButton.Background = Brushes.Purple;
                                backButton.BorderBrush = Brushes.Purple;
                                forwardButton.Background = Brushes.Purple;
                                forwardButton.BorderBrush = Brushes.Purple;
                                settingsButton.Background = Brushes.Purple;
                                settingsButton.BorderBrush = Brushes.Purple;
                                break;

                            case "theme:blackpink;":
                                navbar.Background = Brushes.Black;
                                urlbar.Background = Brushes.Violet;
                                urlbar.BorderBrush = Brushes.Violet;
                                sidebar.Background = Brushes.Black;
                                goButton.Background = Brushes.Violet;
                                goButton.BorderBrush = Brushes.Violet;
                                backButton.Background = Brushes.Violet;
                                backButton.BorderBrush = Brushes.Violet;
                                forwardButton.Background = Brushes.Violet;
                                forwardButton.BorderBrush = Brushes.Violet;
                                settingsButton.Background = Brushes.Violet;
                                settingsButton.BorderBrush = Brushes.Violet;
                                break;
                        }
                    }
                    break;

                case false:
                    break;
            }
        }
    }
}
