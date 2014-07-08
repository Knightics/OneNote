using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for StaticWindow.xaml
    /// </summary>
    public partial class StaticWindow : Window
    {
        public static string WindowTitle = "山高月小";
        public static string ShowText { get { return "水落石出"; } }

        public StaticWindow()
        {
            InitializeComponent();
        }
    }
}
