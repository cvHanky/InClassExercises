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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
            lblPersonCount.Content = $"Person Count {controller.PersonCount}";
            lblIndex.Content = $"Index {controller.PersonIndex}";
            if (controller.PersonCount == 0)
            {
                btnSubmit.Visibility = Visibility.Hidden;
                lblPersonAdded.Visibility = Visibility.Hidden;
                tbFirstName.IsEnabled = false;
                tbLastName.IsEnabled = false;
                tbAge.IsEnabled = false;
                tbTelephoneNo.IsEnabled = false;
                btnDeletePerson.IsEnabled = false;
                btnUp.IsEnabled = false;
                btnDown.IsEnabled = false;
            }

        }
        private void UpdateText()
        {
            lblPersonCount.Content = $"Person Count {controller.PersonCount}";
            lblIndex.Content = $"Index {controller.PersonIndex}";
            tbFirstName.Text = controller.CurrentPerson.FirstName;
            tbLastName.Text = controller.CurrentPerson.LastName;
            tbAge.Text = controller.CurrentPerson.Age.ToString();
            tbTelephoneNo.Text = controller.CurrentPerson.TelephoneNo;
            lblPersonAdded.Visibility = Visibility.Hidden;
            if (controller.PersonCount - 1 == controller.PersonIndex)
            {
                btnDown.IsEnabled = false;
            }
            else
            {
                btnDown.IsEnabled = true;
            }
            if (controller.PersonIndex == 0)
            {
                btnUp.IsEnabled = false;
            }
            else
            {
                btnUp.IsEnabled = true;
            }
        }
        private void btnNewPerson_Click(object sender, RoutedEventArgs e)
        {
            tbFirstName.IsEnabled = true;
            tbFirstName.Clear();
            tbFirstName.Focus();
            tbLastName.Clear();
            tbLastName.IsEnabled = true;
            tbAge.Clear();
            tbAge.IsEnabled = true;
            tbTelephoneNo.Clear();
            tbTelephoneNo.IsEnabled = true;
            btnSubmit.Visibility = Visibility.Visible;
            lblPersonAdded.Visibility = Visibility.Hidden;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            controller.NextPerson();
            controller.CurrentPerson.FirstName = tbFirstName.Text;
            controller.CurrentPerson.LastName = tbLastName.Text;
            controller.CurrentPerson.Age = int.Parse(tbAge.Text);
            controller.CurrentPerson.TelephoneNo = tbTelephoneNo.Text;
            UpdateText();
            lblPersonAdded.Visibility = Visibility.Visible;
            btnSubmit.Visibility = Visibility.Hidden;
            btnDeletePerson.IsEnabled = true;
            btnUp.IsEnabled = true;
            btnDown.IsEnabled = true;
        }

        private void btnDeletePerson_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            UpdateText();
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            UpdateText();
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            UpdateText();
        }
    }
}
