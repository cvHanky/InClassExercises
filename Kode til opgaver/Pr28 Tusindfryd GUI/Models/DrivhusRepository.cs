using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr28_Tusindfryd_GUI.Models
{
    public class DrivhusRepository
    {
        private ObservableCollection<Drivhus> _drivhusList = new ObservableCollection<Drivhus>();

        public DrivhusRepository()
        {
            _drivhusList = new ObservableCollection<Drivhus>();
            Add("Drivhus 1");
            Add("Drivhus 2");
            Add("Drivhus 3");
        }

        public Drivhus Add(string name)
        {
            Drivhus p = new Drivhus(name);
            _drivhusList.Add(p);
            return p;
        }

        public ObservableCollection<Drivhus> Get()
        {
            return _drivhusList;
        }
    }
}
