using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using WPFAndMVVM2.Commands;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<PersonViewModel> PersonsVM { get; set; }
        public MainViewModel()
        {
            PersonsVM = new ObservableCollection<PersonViewModel>();
            foreach (Person person in personRepo.GetAll())
            {
                PersonsVM.Add(new PersonViewModel(person));
            }
        }
        private PersonViewModel selectedPerson;

        public PersonViewModel SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }
        public ICommand DltCommand { get; set; } = new DeleteCommand();
        public ICommand NewCmd { get; set; } = new NewCommand();

        public void AddDefaultPerson()
        {
            PersonViewModel pvm = new PersonViewModel(personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone"));
            pvm.FirstName = "Specify FirstName";
            pvm.LastName = "Specify LastName";
            pvm.Age = 0;
            pvm.Phone = "Specify Phone";
            SelectedPerson = pvm;
            PersonsVM.Add(pvm);
        }

        public void DeleteSelectedPerson()
        {
            SelectedPerson.DeletePerson(personRepo);
            PersonsVM.Remove(SelectedPerson);
        }

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

    }
}
