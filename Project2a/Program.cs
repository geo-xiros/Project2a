using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoNumbersCalculator twoNumbersCalculator1 = new TwoNumbersCalculator();
            TwoNumbersCalculator twoNumbersCalculator2 = new TwoNumbersCalculator();

            int result1 = twoNumbersCalculator1.GetTwoNumbersCalculation();
            Console.WriteLine(result1);
            int result2 = twoNumbersCalculator2.GetTwoNumbersCalculation();
            Console.WriteLine(result2);

            Console.ReadLine();

        }
    }
}
