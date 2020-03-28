using System;

namespace HelloAccess
{
    class Program
    {
        static void Main(string[] args)
        {
           // RaceCar raceCar = new RaceCar();
            Car car = new Car("Timothy");
            Console.WriteLine(car.Owner);

            Console.WriteLine("Hello World!");
        }
    }


    class Vehicle
    {
        public Vehicle(string owner)
        {
            this.Owner = owner;
        }
        public string Owner { get; set; }       
    }


    class Car : Vehicle
    {
        public Car(string owner):base(owner)
        {
            this.Owner = "Car Onwer";
        }
        public void ShowOnwer()
        {
            Console.WriteLine(base.Owner);  //base 基类对象,只能向上访问一层，访问上一级基类的对象。
            Console.WriteLine(this.Owner);  //访问
        }
    }


    //父类的实例构造器，是不能被子类所继承的
}