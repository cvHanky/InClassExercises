using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05_lommeregner
{
    public class Calculator
    {
        public int Add(int x, int y)
        { return x + y; }

        public int Subtract(int x, int y) 
        {  return x - y; }

        public int Multiply(int x, int y) 
        { return x * y; }

        public double Divide(double x, double y) 
        { return x / y; }
    }
}
