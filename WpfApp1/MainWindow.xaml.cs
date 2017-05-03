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

namespace WpfApp1
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

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GetColour();
        }

        public void GetColour()
        {
            byte rr = (byte)slider1.Value;
            byte gg = (byte)slider2.Value;
            byte bb = (byte)slider3.Value;
            Color cc = Color.FromRgb(rr, gg, bb);
            SolidColorBrush colorBrush = new SolidColorBrush(cc);
            stackPanel1.Background = colorBrush;
            MyColour.Text = colorBrush.Color.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetColour();
        }
    }
}
