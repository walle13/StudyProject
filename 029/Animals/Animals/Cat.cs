using System;
using System.Collections.Generic;
using System.Text;
using BabyStroller.SDK;

namespace Animals
{
    [Unfinished]
    public class Cat:IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Meow!");
            }
        }
    }
}
