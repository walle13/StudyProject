using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            HanoiCalculator c = new HanoiCalculator();
            Console.WriteLine(c.CalculatorHanoi(64));
            Console.ReadLine();
        }
    }
    class HanoiCalculator
    {
        public ulong CalculatorHanoi(int count)
        {
            ulong stepForOnlyCerrentDish = 1;
            if (count == 1)
            {
                return stepForOnlyCerrentDish;
            }
            ulong totalSteps = stepForOnlyCerrentDish + CalculatorHanoi(count - 1) * 2;
            return totalSteps;
        }

    }
}
