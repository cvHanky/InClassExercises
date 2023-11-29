using Pr30_WPFCommandbinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr30_WPFCommandbinding.ViewModels
{
    public class MainViewModel
    {
        private ProductRepository _productRepo;
        public ObservableCollection<ProductViewModel> ProductsVM { get; set; }
        public ProductViewModel SelectedProduct { get; set; }

        public MainViewModel()
        {
            _productRepo = new ProductRepository();
            ProductsVM = new ObservableCollection<ProductViewModel>();
            foreach (Product p in _productRepo.GetAll())
            {
                ProductsVM.Add(new ProductViewModel(p));
            }
        }

        public void AddProduct()
        {

        }
    }
}
