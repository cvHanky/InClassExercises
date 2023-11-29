using Pr30_WPFCommandbinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr30_WPFCommandbinding.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; OnPropertyChanged("Name"); }
		}

		private double price;

        public double Price
		{
			get { return price; }
			set { price = value; OnPropertyChanged("Price"); }
		}

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ProductViewModel(Product product)
        {
            Name = product.Name;
            Price = product.Price;
        }
    }
}
