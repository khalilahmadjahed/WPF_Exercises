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
using System.Windows.Shapes;

namespace WPF_Exercises
{
    /// <summary>
    /// Interaction logic for RadioButton.xaml
    /// </summary>
    public partial class RadioButton : Window
    {
        public RadioButton()
        {
            InitializeComponent();
        }
        private void yes_chechked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes, we love you!");
            
        }
        
        private void no_checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No, we hate you!");
        }
        private void maybe_checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Umm, 50 50");
        }
    }
}
