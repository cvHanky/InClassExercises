using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr15_Disaheim
{
    public class Course
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        public Course(string name) : this(name, 0) { } // Chained constructor. I guess that the standard duration is 0.
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}
