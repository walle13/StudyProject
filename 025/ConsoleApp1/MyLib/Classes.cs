using System;

namespace MyLib
{
  
    public class Vehicle
    {
        protected int _rpm;
        private int _fuel;

        public void Refuel()
        {
            this._fuel = 100;
        }

        protected void Burn(int fuel)
        {

            _fuel -= fuel;
        }

        public void Acccelerate()
        {
            Burn(1);
            _rpm += 1000;   //前面有下划线 _ 就是实例字段
        }
        public int Speed { get { return _rpm / 100; }}
            //internal string Owner { get; set; }
    }

    public class Car : Vehicle
    {
        public void TurboAccelerate()
        {
            Burn(1);
            Burn(1);
            _rpm += 3000;
        }
        /*
        public void ShowOnwer()
        {
            Console.WriteLine(base.Owner);
        }
        */
    }

   
}
