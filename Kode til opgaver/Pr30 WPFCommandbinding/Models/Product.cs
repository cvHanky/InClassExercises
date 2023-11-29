using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr30_WPFCommandbinding.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, string productType, double price)
        {
            Id = id;
            Name = name;
            ProductType = productType;
            Price = price;
        }
        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }
    }
}
