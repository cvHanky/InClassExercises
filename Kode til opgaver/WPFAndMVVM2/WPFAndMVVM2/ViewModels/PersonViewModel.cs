using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person person;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //private string firstName;

        //public string FirstName
        //{
        //    get { return firstName; }
        //    set 
        //    { 
        //        firstName = value;
        //        OnPropertyChanged("FirstName");
        //    }
        //}
        //private string lastName;

        //public string LastName
        //{
        //    get { return lastName; }
        //    set { lastName = value;
        //        OnPropertyChanged("LastName");
        //    }
        //}
        //private int age;

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value;
        //        OnPropertyChanged("Age");
        //    }
        //}
        //private string phone;

        //public string Phone
        //{
        //    get { return phone; }
        //    set { phone = value;
        //        OnPropertyChanged("Phone");
        //    }
        //}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public PersonViewModel(Person person)
        {
            this.person = person;
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
            Phone = person.Phone;
        }
        public void DeletePerson(PersonRepository personRepo)
        {
            personRepo.Remove(person.Id);
        }
    }
}
