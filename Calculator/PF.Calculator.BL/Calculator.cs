using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF.Calculator.BL
{
    public class Calculator
    {
     
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Multi(double a, double b)
        {
            return a * b;
        }
        public double Dev(double a, double b)
        {
            return a / b;
        }

    }
}
