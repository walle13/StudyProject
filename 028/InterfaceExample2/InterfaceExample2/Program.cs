using System;

namespace InterfaceExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();      //类实例化
            Car car = new Car(engine);
            //var car = new Car(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);
            Console.WriteLine("Hello World!");
        }
    }

    class Engine
    {
        public int RPM{ get; private set;}
        public void Work(int gas)
        {
            this.RPM = 100 * gas;
        }
    }
    0
    class Car
    {
        private Engine _engine; //Engine类型字段
        public Car(Engine engine)   //创建一个Car 的方法，需要传入一个 engine 的参数
        {
            _engine = engine;
        }

        public int Speed { get; private set; }

        public void Run(int gas)
        {   
            _engine.Work(gas);
            this.Speed = _engine.RPM / 100;
            
        }
    }
}
