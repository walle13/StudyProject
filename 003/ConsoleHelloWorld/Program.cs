using System;
using Tools;
namespace ConsoleHelloWorld

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hwllo World!");
            double result = Calculator.Div(3, 0);
            Console.WriteLine(result);
        }
    }
}
