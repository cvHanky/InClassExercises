using Pr28_Tusindfryd_GUI.Views;
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

namespace Pr28_Tusindfryd_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StartProductionView spw;
        public MainWindow()
        {
            InitializeComponent();
            spw = new StartProductionView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (spw.ShowDialog() == true)
            {
                Binding b = new Binding();
            }
        }
    }
}
