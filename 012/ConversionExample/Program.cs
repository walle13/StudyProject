using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 强制转换
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int x = Convert.ToInt32(str1);
            int y = Convert.ToInt32(str2);
            Console.WriteLine(x + y);
            Console.ReadLine();*/
            uint x = 65536;
            char cha = 'H';
            ushort y = (ushort)x; //cast显示数据转换成 uint TO ushort 型,记录可以查表
            Console.WriteLine(y);

            Console.WriteLine(Convert.ToInt32(cha)) ;

            Teacher t = new Teacher();
            Human h = t;
            Animal a = h;
            a.Eat();
            Console.ReadLine();

        }
        
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating.....");
        }
    }
    class Human : Animal        //派生出来 Human 类
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }
    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("I teach programming.");
        }
    }
}
