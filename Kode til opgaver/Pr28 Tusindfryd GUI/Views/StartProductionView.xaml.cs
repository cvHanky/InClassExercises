using Pr28_Tusindfryd_GUI.ViewModels;
using Pr28_Tusindfryd_GUI.Models;
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

namespace Pr28_Tusindfryd_GUI.Views
{
    /// <summary>
    /// Interaction logic for StartProductionView.xaml
    /// </summary>
    public partial class StartProductionView : Window
    {
        StartProductionViewModel viewModel = new StartProductionViewModel();
        public StartProductionView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void btnBekræft_Click(object sender, RoutedEventArgs e)
        {
            if (cboxBlomstersort.SelectedItem != null &&
                cboxProdbakke.SelectedItem != null &&
                cboxDrivhus.SelectedItem != null &&
                DateTime.TryParse(dtpDato.Text, out DateTime date) == true &&
                int.TryParse(tbAntal.Text, out int i))
            {
                Drivhus drivhus = new Drivhus(cboxBlomstersort.SelectedItem.ToString());
                Produktionsbakke pbakke = new Produktionsbakke(cboxProdbakke.SelectedItem.ToString());
                DateTime startDato = DateTime.Parse(dtpDato.Text);
                Blomstersort blomst = new Blomstersort(cboxBlomstersort.SelectedItem.ToString());
                int startAntal = int.Parse(tbAntal.Text);
                viewModel.AddProduktion(new Produktion(drivhus, pbakke, blomst, startDato, startAntal));
                DialogResult = true;
            }
        }

        private void btnFortryd_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
