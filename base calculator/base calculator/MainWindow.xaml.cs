using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace base_calculator
{
    public partial class MainWindow
    {
        TextBox focusedTxtbox;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BtnClick(object sender, RoutedEventArgs e)
        {
            if (focusedTxtbox != null && ((Button)sender).Tag != null)
            {
                focusedTxtbox.Text += ((Button)sender).Tag;
                focusedTxtbox.Select(focusedTxtbox.Text.Length, 0);
            }
        }

        private void TxtBoxGotFocus(object sender, RoutedEventArgs e)
        {
            focusedTxtbox = (TextBox)sender;
        }

        private void Backspace(object sender, RoutedEventArgs e)
        {
            if (focusedTxtbox != null && focusedTxtbox.Text.Length != 0)
            {
                focusedTxtbox.Text = focusedTxtbox.Text.Remove(focusedTxtbox.CaretIndex - 1, 1);
                focusedTxtbox.Select(focusedTxtbox.Text.Length, 0);
            }
        }
    }
}