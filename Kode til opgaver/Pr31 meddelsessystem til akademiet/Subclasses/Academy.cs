using Pr31_meddelsessystem_til_akademiet.Superclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr31_meddelsessystem_til_akademiet.Subclasses
{
    public class Academy : SuperAcademy
    {
        public string Name { get; }
        private string message;

        public string Message
        {
            get { return message; }
            set 
            { 
                message = value;
                Notify();
            }
        }


        public Academy(string name)
        {
            Name = name;
        }
    }
}
