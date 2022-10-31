using CefSharp.DevTools.Debugger;
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
    /// Interakční logika pro InnitSettingsTab.xaml
    /// </summary>
    public partial class InnitSettingsTab : UserControl
    {
        public InnitSettingsTab()
        {
            InitializeComponent();
            SetupComponentsFromXAML();
        }

        public void SetupComponentsFromXAML()
        {
            def1.Width = new GridLength(SystemParameters.PrimaryScreenWidth - 1200);
            def2.Width = new GridLength(1200);
        }

        public void SetRedTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:red;");
                    break;

                case false:
                    break;
            }
        }

        public void SetOrangeTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:orange;");
                    break;

                case false:
                    break;
            }
        }

        public void SetYellowTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:yellow;");
                    break;

                case false:
                    break;
            }
        }

        public void SetYGreenTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:yellowgreen;");
                    break;

                case false:
                    break;
            }
        }

        public void SetGreenTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:green;");
                    break;

                case false:
                    break;
            }
        }

        public void SetAmariTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:aquamarine;");
                    break;

                case false:
                    break;
            }
        }

        public void SetCyanTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:cyan;");
                    break;

                case false:
                    break;
            }
        }

        public void SetLBlueTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:lightblue;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBlueTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blue;");
                    break;

                case false:
                    break;
            }
        }

        public void SetPurpleTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:purple;");
                    break;

                case false:
                    break;
            }
        }

        public void SetPinkTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:pink;");
                    break;

                case false:
                    break;
            }
        }

        // black themes
        public void SetBRedTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackred;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBOraTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackorange;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBYellTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackyellow;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBYGrTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackyellowgreen;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBGreTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackgreen;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBAmarTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackaquamarine;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBCyaTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackcyan;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBLBlTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blacklightblue;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBBluTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackblue;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBPurTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackpurple;");
                    break;

                case false:
                    break;
            }
        }

        public void SetBPinTheme(object sender, RoutedEventArgs e)
        {
            switch (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme"))
            {
                case true:
                    System.IO.File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\LIMO-Development\\LIMO-Browser\\settings\\Themes.limobrowsertheme", "theme:blackpink;");
                    break;

                case false:
                    break;
            }
        }
    }
}
