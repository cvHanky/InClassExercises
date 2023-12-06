using Pr33_Meddelsessystem_med_delegates.Interfaces;
using Pr33_Meddelsessystem_med_delegates.Superclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr33_Meddelsessystem_med_delegates.Domain
{
    public class Student : Person,IObserver
    {
        public string Message { get; set; }

        public Student (string name) : base(name) // this calls the constructor of the "base" class, which is person. 
        {
        }
        public void Update(object sender, EventArgs e)
        {
            if (sender is Academy a)
            {
                Message = a.Message;
                Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {a.Name}");
            }
            else
                Console.WriteLine($"Student <{Name}> does not have an academy attached.");
        }
    }
}
