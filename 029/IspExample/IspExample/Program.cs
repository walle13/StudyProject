using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace IspExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank), typeof(HeavyTank)); //**依赖注入**，只要将这里 HeavyTank 改成MediumTank
            sc.AddScoped(typeof(IVehicle), typeof(MediumTank));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();
            //==========华丽的分割线===========//
            var driver = sp.GetService<Driver>();
            driver.Drive();

            ITank tank = sp.GetService<ITank>();
            tank.Fire();
            tank.Run();

            /*
            ITank tank = new HeavyTank();
            var t = tank.GetType();
            object o = Activator.CreateInstance(t);
            MethodInfo fireMi = t.GetMethod("Fire");        //反射
            MethodInfo runMi = t.GetMethod("Run");
            fireMi.Invoke(o, null);
            runMi.Invoke(o, null);
            */

            /*
            //var driver = new Driver(new HeavyTank()); //接口
            //driver.Drive();
            */
            Console.WriteLine("Hello World!");
        }
    }

    class Driver        //驾驶至需要 车能跑run()
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive()
        {
            _vehicle.Run();
        }
    }

    interface IVehicle
    {
        void Run();
    }

    class Car:IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }

    class Truck:IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

    interface IWeapon
    {
        void Fire();
    }

    interface ITank:IVehicle,IWeapon    //
    {
       
    }

    class LightTank:ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }
        public void Run()
        {
            Console.WriteLine("Ka ka ka ...");
        }
    }

    class MediumTank:ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }
        public void Run()
        {
            Console.WriteLine("Ka ka ka ...");
        }
    }

    class HeavyTank:ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom !!");

        }
        public void Run()
        {
            Console.WriteLine("Ka! ka! ka! ...");
        }
    }
}
