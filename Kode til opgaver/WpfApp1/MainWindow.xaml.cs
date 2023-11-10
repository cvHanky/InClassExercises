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

        private void btnScrollUp_Click(object sender, RoutedEventArgs e)
        {
            string temp = tbName1.Text;
            tbName1.Text = tbName2.Text;
            tbName2.Text = tbName3.Text;
            tbName3.Text = tbName4.Text;
            tbName4.Text = temp;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbName1.Clear();
            tbName2.Clear();
            tbName3.Clear();
            tbName4.Clear();
        }

        private void btnScrollDown_Click(object sender, RoutedEventArgs e)
        {
            string temp = tbName4.Text;
            tbName4.Text = tbName3.Text;
            tbName3.Text = tbName2.Text;
            tbName2.Text = tbName1.Text;
            tbName1.Text = temp;
        }
    }
}
