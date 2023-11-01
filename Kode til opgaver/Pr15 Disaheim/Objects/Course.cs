using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr15_Disaheim.Objects
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue { get; set; } = 875.0;
        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        public Course(string name) : this(name, 0) { } // Chained constructor. I guess that the standard duration is 0.
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public double GetValue()
        {
            double result = 0;
            int remainder = DurationInMinutes % 60;

            if (remainder > 0)
            {
                result = (DurationInMinutes / 60 + 1) * CourseHourValue;
            }
            else if (remainder == 0)
            {
                result = DurationInMinutes / 60 * CourseHourValue;
            }

            return result;
        }
    }
}
