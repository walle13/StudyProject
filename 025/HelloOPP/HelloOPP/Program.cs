using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOPP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 继承实例
            Type t = typeof(Car);
            Type tb = t.BaseType;
            Type tTop = tb.BaseType;
            Console.WriteLine(tTop.BaseType == null);
            Console.WriteLine(tTop);
            
            */



            //是一个 is a 概念
            Car car = new Car();
            Console.WriteLine(car is Vehicle);
            Console.ReadLine();
        }
    }

    class Vehicle
    {

    }
    
    class Car:Vehicle
    {

    }
}
