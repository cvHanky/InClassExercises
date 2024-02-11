using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr33_delegates_bonusapp
{
    public class Order
    {
        private List<Product> products = new List<Product>();
        public BonusProvider Bonus { get; set; }

        #region Methods
        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public double GetValueOfProducts()
        {
            double value = 0;
            foreach (Product p in products)
            {
                value += p.Value;
            }
            return value;
        }
        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }
        public double GetBonus(Func<double, double> bonusProvider) // GetBonus() overload
        {
            return bonusProvider(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            double price = 0;
            price += GetValueOfProducts();
            price -= GetBonus();
            return price;
        }
        public double GetTotalPrice(Func<double, double> bonusProvider)                               // GetTotalPrice() overload
        {
            double price = 0;
            price += GetValueOfProducts();
            price -= GetBonus(bonusProvider);
            return price;
        }

        #endregion
    }
}
