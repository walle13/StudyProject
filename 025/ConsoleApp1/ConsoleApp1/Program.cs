using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            Car car = new Car();
            car.Acccelerate();
            car.Acccelerate();
            Console.WriteLine(car.Speed);

            car.TurboAccelerate();
            Console.WriteLine(car.Speed);

            Bus bus = new Bus();
            bus.SlowAccelerate();
            Console.WriteLine(bus.Speed);
            //vehicle.Owner = "Timothy";
            //Console.WriteLine(vehicle.Owner);
            Console.ReadLine();
                
        }
    }

    class Bus : Vehicle //公交车类
    {
        public void SlowAccelerate()
        {
            Burn(1);
            _rpm += 500;
        }
    }
}
