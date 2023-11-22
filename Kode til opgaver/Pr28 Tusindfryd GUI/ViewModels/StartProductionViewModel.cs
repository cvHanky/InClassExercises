using Pr28_Tusindfryd_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr28_Tusindfryd_GUI.ViewModels
{
    public class StartProductionViewModel : INotifyPropertyChanged
    {
        private BlomstersortRepository blomstRepo;
        private DrivhusRepository drivhusRepo;
        private ProduktionsbakkeRepository produktionsbakkeRepo;
        private ProduktionRepository produktionRepo;
        public ObservableCollection<Blomstersort> Blomster { get; set; }
        public ObservableCollection<Drivhus> Drivhuse { get; set; }
        public ObservableCollection<Produktionsbakke> Produktionsbakker { get; set; }
        public ObservableCollection<Produktion> Produktioner { get; set; }

        // #### INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        // ####

        public void AddProduktion(Produktion produktion)
        {
            Produktioner.Add(produktion);
            //produktionRepo.Add(produktion);
        }

        public StartProductionViewModel()
        {
            blomstRepo = new BlomstersortRepository();
            drivhusRepo = new DrivhusRepository();
            produktionsbakkeRepo = new ProduktionsbakkeRepository();
            produktionRepo = new ProduktionRepository();
            Blomster = blomstRepo.Get();
            Drivhuse = drivhusRepo.Get();
            Produktionsbakker = produktionsbakkeRepo.Get();
            Produktioner = produktionRepo.Get();
        }

        
    }
}
