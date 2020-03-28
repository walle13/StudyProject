using System;
using System.Collections;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5, };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };  //非泛型的
            Console.WriteLine(Sum(nums1));  //既能处理int[] 整形实例，也可以处理 Arraylist 数组
            Console.WriteLine(Avg(nums1));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Avg(nums2));
            Console.WriteLine("Hello World!");
        }
        

        static int Sum(IEnumerable nums)        //
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }

        static double Avg(IEnumerable nums)
        {
            int sum = 0;
            double count = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
                count++;
            }
            return sum / count;
        }

        /* 2.0
         *      Console.WriteLine(Sum(nums2));
         *     Console.WriteLine(Avg(nums2));
        static int Sum(ArrayList nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }

        static double Avg(ArrayList nums)
        {
            int sum = 0;
            double count = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
                count++;
            }
            return sum / count;
        }

        */

        /* 1.0
         *     Console.WriteLine(Sum(nums1));
         *     Console.WriteLine(Avg(nums1));
         * 
        static int Sum(int[] nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += n;
            }
            return sum;
        }

        static double Avg(int[] nums)
        {
            int sum = 0;
            double count = 0;
            foreach (var n in nums)
            {
                sum += n;
                count++;
            }
            return sum / count;
        }
        */
    }
}
