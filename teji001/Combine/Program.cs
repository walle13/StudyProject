using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele dele1 = new MyDele(M1);

            Console.ReadLine();
        }
        static void M1()
        {
            Console.WriteLine("M1 is called!");
        }
    }
    class Student
    {
        public void SayHello()
        {
            Console.WriteLine(
                
                );
        }
    }

    delegate void MyDele();
}
