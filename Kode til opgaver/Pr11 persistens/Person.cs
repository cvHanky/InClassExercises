using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11_persistens
{
    public class Person 
    {
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }
        public Person(string name, DateTime birthDate, double height, bool isMarried)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = 0;
        }

        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 0)
                    name = value;
                else
                    throw new Exception("Fejl. Ugyldigt navn.");
            }
        }
        public DateTime BirthDate
        { get { return birthDate; } 
            set
            {
                if (value.Year < 1900)
                    throw new Exception("Fejl. Dato kan ikke være før år 1900.");
                else if (value.Year >= 1900)
                    birthDate = value;
                else
                    throw new Exception("Fejl. Kunne ikke forstå input.");
            }
        }
        public double Height
        { get { return height; } 
            set
            {
                if (value > 0)
                    height = value;
                else
                    throw new Exception("Fejl. Ugyldig højde.");
            }
        }
        public bool IsMarried
        { get { return isMarried; } set { isMarried = value; } }
        public int NoOfChildren
        { get { return noOfChildren; }
            set
            {
                if (value >= 0)
                    noOfChildren = value;
                else
                    throw new Exception("Fejl. Ugyldigt antal børn.");
            }
        }

        public string MakeTitle()
        {
            string title = Name + ";" + BirthDate.ToString() + ";" + Height.ToString() + ";" + IsMarried.ToString() + ";" + NoOfChildren.ToString();
            return title;
        }
    }
}
