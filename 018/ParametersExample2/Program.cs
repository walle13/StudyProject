using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[] { 1, 2, 3 };
            int result = CalculateSum(myIntArray);
            Console.WriteLine(result);
           // Console.ReadLine();234


            int x = 100;
            int y = 200;
            int z = 300;
            Console.WriteLine("{0}+{1}={2}", x,y,z);  //会先创建一个数组，然后做计算

            PrintInfo("Tim", 34);   //非具名调用
            PrintInfo(name: "Tim", age: 34);    //具名参数调用

            double pi = 3.14159;
            // double pi2 = Math.Round(pi, 4);
            double pi2 = pi.Round(4);
            Console.WriteLine(pi2);

            Console.ReadLine();
        }
        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }

            return sum;
        }
        static void PrintInfo(string name="tim", int age=24)    //一般不用用
        {
            Console.WriteLine("Hello {0},you are {1}", name, age);
        }

        
    }
    static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
}
