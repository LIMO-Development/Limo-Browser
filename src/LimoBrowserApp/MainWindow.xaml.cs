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
            switch (tabs.SelectedIndex == 0)
            {
                case true:
                    tabs.SelectedIndex = 3;
                    break;

                case false:
                    tabs.SelectedIndex = tabs.SelectedIndex + 1;
                    break;
            }
            
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
                            string name5 = name2 + "\\newtabpage";
                            switch (Directory.Exists(name5))
                            {
                                case true:
                                    string name6 = name5 + "\\index.html";
                                    switch (File.Exists(name6))
                                    {
                                        case true:
                                            File.WriteAllText(name6, "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>LIMO Browser</title>\r\n    <script src=\"https://kit.fontawesome.com/301467f7b5.js\" crossorigin=\"anonymous\"></script>\r\n    <style>\r\n        @import url('https://fonts.googleapis.com/css2?family=Zen+Kurenaido&display=swap');\r\n\r\n        body {\r\n            margin: 0;\r\n            padding: 0;\r\n            font-family: 'Zen Kurenaido', sans-serif;\r\n            background: rgb(55, 55, 55);\r\n        }\r\n\r\n        .title-container {\r\n            position: relative;\r\n            height: 220px;\r\n            width: 100%;\r\n            display: flex;\r\n            justify-content: center;\r\n        }\r\n\r\n        .browser-title-text {\r\n            position: absolute;\r\n            top: 100px;\r\n            color: red;\r\n            font-size: 50px;\r\n            filter: drop-shadow(5px 5px 5px rgba(20, 20, 20, 1));\r\n        }\r\n\r\n        .browser-container {\r\n            position: absolute;\r\n            top: 220px;\r\n            width: 100%;\r\n            height: 150px;\r\n            display: flex;\r\n            justify-content: center;\r\n        }\r\n\r\n        .browser-form {\r\n            position: relative;\r\n            height: 55px;\r\n            width: 300px;\r\n            background: rgb(45, 45, 45);\r\n            border-radius: 30px;\r\n            box-shadow: 10px 10px 10px rgba(20, 20, 20, 0.5);\r\n        }\r\n\r\n        .browser-submit-button {\r\n            position: absolute;\r\n            height: 55px;\r\n            width: 55px;\r\n            border: none;\r\n            font-size: 30px;\r\n            border-radius: 30px;\r\n            background: rgb(50, 50, 50);\r\n        }\r\n\r\n        .browser-input {\r\n            position: absolute;\r\n            left: 55px;\r\n            top: 1px;\r\n            height: 50px;\r\n            width: 240px;\r\n            border: none;\r\n            font-size: 35px;\r\n            border-bottom: 2px solid red;\r\n            border-top-right-radius: 30px;\r\n            border-bottom-right-radius: 30px;\r\n            background: transparent;\r\n        }\r\n\r\n        .browser-input:focus {\r\n            outline: none;\r\n        }\r\n\r\n        .apps-container {\r\n            position: absolute;\r\n            top: 370px;\r\n            width: 100%;\r\n            height: 230px;\r\n            display: flex;\r\n            justify-content: center;\r\n        }\r\n\r\n        .apps-inner-container {\r\n            position: relative;\r\n            width: 80%;\r\n            background: red;\r\n            height: 220px;\r\n            border-radius: 30px;\r\n            padding: 10px;\r\n            box-shadow: 10px 10px 10px rgba(20, 20, 20, 0.5);\r\n        }\r\n\r\n        .apps-row1 {\r\n            position: absolute;\r\n            top: 10px;\r\n            left: 25px;\r\n            width: calc(100% - 50px);\r\n            display: flex;\r\n            justify-content: center;\r\n        }\r\n\r\n        .apps-row2 {\r\n            position: absolute;\r\n            bottom: 10px;\r\n            width: calc(100% - 50px);\r\n            display: flex;\r\n            justify-content: center;\r\n        }\r\n\r\n        .app-card {\r\n            height: 100px;\r\n            width: 125px;\r\n            background: rgb(45, 45, 45);\r\n            margin-left: 10px;\r\n            border-radius: 10px;\r\n            text-align: center;\r\n            box-shadow: 5px 5px 5px rgba(100, 0, 0, 0.5);\r\n            transition: all 0.5s;\r\n        }\r\n\r\n        .app-card:hover {\r\n            transform: translate(-5px, -5px);\r\n            box-shadow: 10px 10px 5px rgba(100, 0, 0, 0.5);\r\n        }\r\n\r\n        .fab {\r\n            font-size: 100px;\r\n        }\r\n\r\n        .fa-youtube {\r\n            color: red;\r\n        }\r\n\r\n        .fa-tiktok {\r\n            color: black;\r\n        }\r\n\r\n        .fa-discord {\r\n            color: blue;\r\n        }\r\n\r\n        .fa-instagram {\r\n            color: magenta;\r\n        }\r\n\r\n        .fa-twitter {\r\n            color: cornflowerblue;\r\n        }\r\n\r\n        .fa-steam {\r\n            color: darkblue;\r\n        }\r\n\r\n        .fa-spotify {\r\n            color: lime;\r\n        }\r\n\r\n        .netflix-logo {\r\n            color: red;\r\n            font-size: 35px;\r\n        }\r\n\r\n        .credits-container {\r\n            position: absolute;\r\n            top: 600px;\r\n            height: calc(100% - 600px);\r\n            width: 100%;\r\n            display: flex;\r\n            justify-content: bottom;\r\n        }\r\n\r\n        .credits-text {\r\n            position: relative;\r\n            top: 50px;\r\n            color: red;\r\n            font-size: 25px;\r\n            filter: drop-shadow(5px 5px 5px rgba(20, 20, 20, 1));\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class=\"title-container\">\r\n        <h1 class=\"browser-title-text\">LIMO Browser</h1>\r\n    </div>\r\n    <div class=\"browser-container\">\r\n        <form action=\"https://www.google.com/search\" method=\"get\" class=\"browser-form\">\r\n            <input type=\"hidden\" name=\"client\" value=\"limobrowser\">\r\n            <button class=\"browser-submit-button\"><i class=\"fas fa-search\"></i></button>\r\n            <input type=\"text\" name=\"q\" class=\"browser-input\">\r\n        </form>\r\n    </div>\r\n    <div class=\"apps-container\">\r\n        <div class=\"apps-inner-container\">\r\n            <div class=\"apps-row1\">\r\n                <a href=\"https://www.youtube.com\">\r\n                    <div class=\"app-card\">\r\n                        <i class=\"fab fa-youtube\"></i>\r\n                    </div>\r\n                </a>\r\n                <a href=\"https://www.tiktok.com\">\r\n                    <div class=\"app-card\">\r\n                        <i class=\"fab fa-tiktok\"></i>\r\n                    </div>\r\n                </a>\r\n                <a href=\"https://www.discord.com/app\">\r\n                    <div class=\"app-card\">\r\n                        <i class=\"fab fa-discord\"></i>\r\n                    </div>\r\n                </a>\r\n                <a href=\"https://www.instagram.com\">\r\n                    <div class=\"app-card\">\r\n                        <i class=\"fab fa-instagram\"></i>\r\n                    </div>\r\n                </a>\r\n                <a href=\"https://www.twitter.com\">\r\n                    <div class=\"app-card\">\r\n                        <i class=\"fab fa-twitter\"></i>\r\n                    </div>\r\n                </a>\r\n                <a href=\"https://store.steampowered.com\">\r\n                    <div class=\"app-card\">\r\n                        <i class=\"fab fa-steam\"></i>\r\n                    </div>\r\n                </a>\r\n                <a href=\"https://open.spotify.com\">\r\n                    <div class=\"app-card\">\r\n                       <i class=\"fab fa-spotify\"></i>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n            <div class=\"apps-row2\">\r\n                <a href=\"https://www.netflix.com\">\r\n                    <div class=\"app-card\">\r\n                        <i class=\"netflix_logo\">N</i>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"credits-container\">\r\n        <h1 class=\"credits-text\">Newtab page is inspired by:<br> Opera GX newtab,<br> Google search engine page</h1>\r\n    </div>\r\n</body>\r\n</html>");
                                            break;

                                        case false:
                                            File.Create(name6);
                                            break;
                                    }
                                    break;

                                case false:
                                    Directory.CreateDirectory(name5);
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
                    case "tabplacement:top;":
                        tabs.TabStripPlacement = Dock.Top;
                        break;

                    case "tabplacement:bottom;":
                        tabs.TabStripPlacement = Dock.Bottom;
                        break;

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
                        allControls.Background = Brushes.HotPink;
                        tabs.Background = Brushes.HotPink;
                        break;

                    // black background themes
                    case "theme:blackred;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Red;
                        break;

                    case "theme:blackorange;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Orange;
                        break;

                    case "theme:blackyellow;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Yellow;
                        break;

                    case "theme:blackyellowgreen;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.YellowGreen;
                        break;

                    case "theme:blackgreen;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Lime;
                        break;

                    case "theme:blackaquamarine;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Aquamarine;
                        break;

                    case "theme:blackcyan;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Cyan;
                        break;

                    case "theme:blacklightblue;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.LightBlue;
                        break;

                    case "theme:blackblue;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Blue;
                        break;

                    case "theme:blackpurple;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Purple;
                        break;

                    case "theme:blackpink;":
                        allControls.Background = Brushes.Black;
                        tabs.Background = Brushes.Black;
                        tabs.BorderBrush = Brushes.Violet;
                        break;
                }
            }
        }

        public void AddSettingsTabToTabControl(object sender, RoutedEventArgs e)
        {
            TabItem newtab = new TabItem();
            InnitSettingsTab tab = new InnitSettingsTab();
            newtab.Content = tab;
            newtab.Style = (Style)FindResource("settingstabStyle");
            tabs.Items.Add(newtab);
            switch (tabs.SelectedIndex == 0)
            {
                case true:
                    tabs.SelectedIndex = 3;
                    break;

                case false:
                    tabs.SelectedIndex = tabs.SelectedIndex + 1;
                    break;
            }
        }

        public void RemoveTabFromTabControl(object sender, RoutedEventArgs e)
        {
            switch (tabs.SelectedIndex == 1 || tabs.SelectedIndex == 0)
            {
                case true:
                    break;

                case false:
                    switch (tabs.SelectedIndex == 2)
                    {
                        case true:
                            break;

                        case false:
                            switch (tabs.SelectedIndex == 3)
                            {
                                case true:
                                    tabs.Items.RemoveAt(tabs.SelectedIndex);
                                    tabs.SelectedIndex = 0;
                                    break;

                                case false:
                                    tabs.Items.RemoveAt(tabs.SelectedIndex);
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
