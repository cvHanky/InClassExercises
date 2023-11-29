using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr30_WPFCommandbinding.Models
{
    public class ProductRepository
    {
        private ObservableCollection<Product> _products;

        public ProductRepository()
        {
            _products = new ObservableCollection<Product>();
            _products.Add(new Product("Apple", 7.95));
            _products.Add(new Product("Orange", 5.50));
            _products.Add(new Product("Banana", 8.25));
        }

        public ObservableCollection<Product> GetAll()
        {
            return _products;
        }

        public void Remove(Product product)
        {
            _products.Remove(product);
        }
    }
}
