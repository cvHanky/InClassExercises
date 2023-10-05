using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjekt_til_multiplechoice
{
    public class Cat
    {
        private string navn;
        public string Navn
        { 
            get { return navn; } 
            set { navn = value; }
        }
        public Cat(string navn)
        { 
            this.navn = navn;
        }
        public string CatNavn()
        { 
            return navn;
        }

    }
}
