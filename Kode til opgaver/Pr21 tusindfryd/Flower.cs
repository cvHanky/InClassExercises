using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_tusindfryd
{
    public class Flower
    {
        public string Name { get; set; }
        public int ProductionTimeInDays { get; set; }
        public Double HalfChangeOfValue { get; set; }
        public Double Size { get; set; }
        public Flower(string name, int productionTimeInDays, Double halfChangeOfValue, Double size)
        {
            Name = name;
            ProductionTimeInDays = productionTimeInDays;
            HalfChangeOfValue = halfChangeOfValue;
            Size = size;
        }
    }
}
