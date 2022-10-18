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
            www.Height = (SystemParameters.PrimaryScreenHeight - 30) - 105;
            def1.Width = new GridLength((SystemParameters.PrimaryScreenWidth - 85) - 65);
            urlbar.Width = (SystemParameters.PrimaryScreenWidth - 85) - 65;
        }
    }
}
