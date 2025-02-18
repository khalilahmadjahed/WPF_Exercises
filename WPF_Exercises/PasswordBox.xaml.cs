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
    /// Interaction logic for PasswordBox.xaml
    /// </summary>
    public partial class PasswordBox : Window
    {
        public PasswordBox()
        {
            InitializeComponent();
        }
        private void btn_login(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello " + tbUserName.Text);
        }
    }
}
