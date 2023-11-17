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

namespace Pr25_TusindFrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts;
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
        }
        private void btnOpret_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog createFlowerSortDialog = new CreateFlowerSortDialog();
            if (createFlowerSortDialog.ShowDialog() == true )
            {
                flowerSorts.Add(createFlowerSortDialog.flower);
            }
            tbBlomsterSorter.Text = "";
            foreach (FlowerSort f in flowerSorts)
            {
                tbBlomsterSorter.Text += $"{f.Name}\n";
            }
        }
    }
}
