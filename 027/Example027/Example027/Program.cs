using System;
//抽象类的案例,抽象到具体

namespace Example027    //027 抽象类与开闭原则
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle v = new RaceCar(); //以基类声明变量
            v.Run();
            Console.WriteLine("Hello World!");
        }
    }

    interface IVehicle  //5.0 使用借口来定义， 一般定义为“I”开头。 IVehicle.“接口”本来就包含存“抽象”的虚方法
    {
        void Stop();
        void Run();
        void Fill();
    }
    /*
    
    abstract class VehicleBase  //4.0 创建一个寸虚类
    {
        abstract public void Stop();
        abstract public void Fill();
        abstract public void Run();
    }
    */

    abstract class Vehicle:IVehicle     //5.0 直接修改为抽象类，实现了两个“存虚方法”
    {
        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }

        public  void Fill()
        {
            Console.WriteLine("Pay and fill...");
        }
        abstract public void Run();

        /* 4.0 虚类的抽象类
        public override void Stop()
        {
            Console.WriteLine("Stopped!");
        }

        public override void Fill()
        {
            Console.WriteLine("Pay and fill...");
        }
        */


        //public abstract void Run(); //3.0 去掉方法体，变成纯虚方法。 使用abstract


        /* // 2.0 使用虚方法进行

        public virtual void Run()       //虚方法
        {
            Console.WriteLine("Vehicle is running...");
        }

        */


        /*  1.0 这样写 违背了 “开闭原则”，直接修改原有类的功能
        public void Run(string type)
        {
            if (type == "car")
            {
                Console.WriteLine("Car is running...");
            }
            else if (type == "truck")
            {
                Console.WriteLine("Truck is running...");
            }
            else if (type == "racecar")
            {
                Console.WriteLine("Race car is running...");
            }
        }
        
         */
    }

    class Car :Vehicle   // Car 派生至 Vehicle, Vehicle是基类，Car是其子类
    {
        public override void Run()  //2.0 重写 继承的Run()方法
        {
            Console.WriteLine("Car is running ....");
        }

    }

    class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running ....");
        }
    }

    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Race Car is running...");
        }
    }

    class Student
    {
        //abstract override public void Study();
        
    }
}


/*
 *为做基类而生的“抽象类”与“开放/关闭原则” 
 * 
 */