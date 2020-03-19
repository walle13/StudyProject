using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int x = c.Add(2, 3);
            string data = c.Today();
            //Console.WriteLine(x);   //有输入，有返回值
            //Console.WriteLine(data);    //无输入，有返回值
            //c.PrintSum(4, 6);   //有输入，无输出
            c.PrintXTo0(20);
            c.PrintXTo1(10);
            int result = c.SumFrom1ToY(100);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public string Today()
        {
            int day = DateTime.Now.Day;
            return day.ToString();
        }
        public void PrintSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public void PrintXTo1(int x)
        {
            for (int i = x; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        public void PrintXTo0(int x) //递归函数，自己调用自己
        {
            if (x == 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                PrintXTo0(x - 1);
            }
        }
        public int SumFrom1ToX(int x)
        {
            int result = 0;
            for (int i=1; i < x+1; i++)
            {
                result = result + i;
            }
            return result;

        }
        public int SumFrom1ToY(int y)   //使用递归方法，自己调用自己
        {
            if (y == 1)
            {
                return 1;

            }
            else
            {
                int result = y + SumFrom1ToY(y - 1);
                return result;
            }

        }
       
    }

}
