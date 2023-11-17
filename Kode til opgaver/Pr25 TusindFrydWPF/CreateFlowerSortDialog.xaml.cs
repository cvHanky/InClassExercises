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

namespace Pr25_TusindFrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public FlowerSort flower;
        void IsButtonReady()
        {
            if (tbName.Text != "" &&
                tbBillede.Text != "" &&
                tbProduktionstid.Text != "" &&
                tbHalveringstid.Text != "" &&
                tbStørrelse.Text != "")
            {
                btnOk.IsEnabled = true;
            }
            else btnOk.IsEnabled = false;
        }
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            flower = new FlowerSort();
            btnOk.IsEnabled = false;
        }
        private void tbName_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                flower.Name = tbName.Text;
            }
            catch (FormatException) { }
            IsButtonReady();
        }
        private void tbBillede_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                flower.PicturePath = tbBillede.Text;
            }
            catch (FormatException) { }
            try
            {
                imgImage.Source = new BitmapImage(new Uri(tbBillede.Text));
            }
            catch (UriFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            IsButtonReady();
        }

        private void tbProduktionstid_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                flower.ProductionTime = int.Parse(tbProduktionstid.Text);
            }
            catch (FormatException) 
            {
                MessageBox.Show("Input has to be a number"); 
            }
            IsButtonReady();
        }

        private void tbHalveringstid_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                flower.HalfLifeTime = int.Parse(tbHalveringstid.Text);
            }
            catch (FormatException) 
            {
                MessageBox.Show("Input has to be a number");
            }
            IsButtonReady();
        }

        private void tbStørrelse_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                flower.Size = int.Parse(tbStørrelse.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input has to be a number.");
            }
            IsButtonReady();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // exit
            DialogResult = true;
        }

        private void btnFortryd_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            // also exit, but no save flower
        }

        private void tbStørrelse_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsButtonReady();
        }
    }
}
