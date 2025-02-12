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

namespace WPF_Exercises
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hamid tartug");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is Black!");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is Red!");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is Green!");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is White!");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is Yellow!");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is Blue!");
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is Orange!");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is Pure!");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This color is Magenta!");
        }
    }
}
