using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StatementsExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//需求：80~100 ->A;60~79 ->B;  40~59 ->C;  0~39 ->D ;其他 ->Error
            int score = 101
                ;
            switch (score/10)
            {
                case 10:
                    if (score == 10)
                    {
                        goto case 8;
                    }
                    else
                    {
                        goto default;
                    }
                case 8:
                case 9:            
                    Console.WriteLine("A");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("B");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("C");
                    break;
                case 0:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("D");
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }   */
           
            
            // ****************************
            
            /*  99乘法表
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    //if (b > a)
                    //{
                    //    break;
                    //}
                    Console.Write("{0}x{1}={2}\t", a, b, a * b);
                }
                Console.WriteLine();
            }
            */

            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };

            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var current in intList)
            {
                Console.WriteLine(current);
            }


            /*
            IEnumerator enumerator = intList.GetEnumerator();  //指月
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
               
            }
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);

            }*/
            Console.ReadLine();
            
        }
    }
}
