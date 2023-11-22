using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr28_Tusindfryd_GUI.Models
{
    public class ProduktionsbakkeRepository
    {
        private ObservableCollection<Produktionsbakke> _produktionsbakkeList = new ObservableCollection<Produktionsbakke>();

        public ProduktionsbakkeRepository() 
        {
            _produktionsbakkeList = new ObservableCollection<Produktionsbakke>();
            Add("A1");
            Add("A2");
            Add("A3");
            Add("B1");
            Add("B2");
            Add("B3");
        }

        public Produktionsbakke Add(string name)
        {
            Produktionsbakke p = new Produktionsbakke(name);
            _produktionsbakkeList.Add(p);
            return p;
        }

        public ObservableCollection<Produktionsbakke> Get()
        {
            return _produktionsbakkeList;
        }
    }
}
