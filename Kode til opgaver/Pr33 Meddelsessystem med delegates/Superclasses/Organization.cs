using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr33_Meddelsessystem_med_delegates.Superclasses
{
    public class Organization
    {
        public string Name { get; }
        public string Address { get; set; }
        public Organization(string name) 
        {
            Name = name;
        }
    }
}
