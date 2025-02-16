using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for CheckBox.xaml
    /// </summary>
    public partial class CheckBox : Window
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void cbCheckedAll(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbCheckAll.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
            cbExtraMozzarella.IsChecked = newVal;
        }
        private void cbCheckedSingle(object sender, RoutedEventArgs e)
        {
            cbCheckAll.IsChecked = null;
            if (cbSalami.IsChecked == true && cbMushrooms.IsChecked == true && cbExtraMozzarella.IsChecked == true) 
            {
                cbCheckAll.IsChecked = true;
            }
            if (cbSalami.IsChecked == false && cbMushrooms.IsChecked == false && cbExtraMozzarella.IsChecked == false) 
            {
                cbCheckAll.IsChecked = false;
            }
        }
    }
}
