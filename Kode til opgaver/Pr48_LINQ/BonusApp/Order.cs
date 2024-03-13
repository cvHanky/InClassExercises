using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private IList<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {
            //double valueOfProducts = 0;
            //foreach (Product product in _products)
            //{
            //    valueOfProducts += product.Value;
            //}
            //return valueOfProducts;

            return _products.Sum(x => x.Value);
        }
        public double GetValueOfProducts(DateTime date) 
        {
            return _products.Sum(x => x.AvailableFrom <= date && date <= x.AvailableTo ? x.Value : 0);
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetBonus(DateTime date, BonusProvider bonusProvider)
        {
            return bonusProvider(GetValueOfProducts(date));
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }

        public double GetTotalPrice(DateTime date, BonusProvider bonusProvider)
        {
            return (GetValueOfProducts(date) - GetBonus(date, bonusProvider));
        }

        public List<Product> SortProductOrderByAvailableTo()
        {
            return _products.OrderBy(x => x.AvailableTo).ToList();
        }

        public List<Product> SortProductOrderBy(Func<Product,object> keySelector)
        {
            return _products.OrderBy(keySelector).ToList();
        }
    }
}
