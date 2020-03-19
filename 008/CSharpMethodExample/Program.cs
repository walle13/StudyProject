using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodExample
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.GetCircleArea(10));
        }
    }

    class Calculator
    {
        double Pi = 3.1415926;
        public double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }
        public double GetCylinderVolume(double r, double h)
        {
            return GetCircleArea(r)* h;
        }
        public double GetConeVolume(double r, double h)
        {
            return GetCircleArea(r) * h / 3;
        }
        //public double GetConeVolume(double r, double h)
        //{
        //    return 3.14 * r * r * h / 3;
        //}
 
    }

}
