using Pr28_Tusindfryd_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr28_Tusindfryd_GUI.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<ProduktionRepository> produktionRepo;

        public MainViewModel()
        {
            produktionRepo = new ObservableCollection<ProduktionRepository>();
        }
    }
}
