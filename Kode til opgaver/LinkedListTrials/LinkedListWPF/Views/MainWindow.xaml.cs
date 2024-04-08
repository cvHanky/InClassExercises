using LinkedListWPF.Models;
using LinkedListWPF.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinkedListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            DataContext = viewModel;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ClubMember cb = new ClubMember { FirstName = "Jan", LastName = "Brown", Age = 30, Gender = Gender.Male, Id = 7 };

            if (viewModel.SelectedItem != null )
                viewModel.ClubMembers.InsertAt(viewModel.SelectedIndex, cb);
            else
                viewModel.ClubMembers.InsertAt(0, cb);
        }

        private void btnSwap_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.SelectedItem != null)
            {
                viewModel.ClubMembers.DeleteAt(viewModel.SelectedIndex);
            }
        }
    }
}