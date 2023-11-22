using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr28_Tusindfryd_GUI.Models
{
    public class ProduktionRepository
    {
        private ObservableCollection<Produktion> _produktioner;

        public ProduktionRepository()
        {
            _produktioner = new ObservableCollection<Produktion>();
        }

        public ObservableCollection<Produktion> Get()
        {
            return _produktioner;
        }

        public void Add(Produktion produktion)
        {
            _produktioner.Add(produktion);
        }
    }
}
