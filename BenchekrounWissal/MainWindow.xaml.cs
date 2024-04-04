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

namespace BenchekrounWissal
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
    public MainWindow()
        {
            InitializeComponent();
        }
      
    private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = slider.Value.ToString("0");

            
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number1.Text = slider1.Value.ToString("0");

        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number2.Text = slider2.Value.ToString("0");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            textblock.Text = slider.Value.ToString("0");
            textblock1.Text = slider1.Value.ToString("0");
            textblock2.Text = slider2.Value.ToString("0");
        }
    }
}




