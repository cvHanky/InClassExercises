using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr28_Tusindfryd_GUI.Models
{
    public class BlomstersortRepository
    {
        private ObservableCollection<Blomstersort> _blomstersortList;
        public BlomstersortRepository()
        {
            _blomstersortList = new ObservableCollection<Blomstersort>();
            Add("Solsikke");
            Add("Stedmoderblomst");
            Add("Rose");
        }
        public Blomstersort Add(string name)
        {
            Blomstersort b = new Blomstersort(name);
            _blomstersortList.Add(b);
            return b;
        }
        public ObservableCollection<Blomstersort> Get() 
        {
            return _blomstersortList;
        }
    }
}
