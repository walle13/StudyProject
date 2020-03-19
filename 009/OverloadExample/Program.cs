using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int result = c.Add(100,100);
            double x = c.Add(100D,300D);
            Console.WriteLine(result);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public int Add(int a)
        {
            return a ;
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
