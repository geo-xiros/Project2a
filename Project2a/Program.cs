using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

///1. Ask user to enter two numbers and a symbol. 
///   Choices are (+,-, *, /, %,square root)
///2. Based on symbol choice calculate and print the result.
///3. Check if the 2nd result is a prime number.
///   A prime number is a positive integer that can be dividedonly by 1 and itself.
///4. Use the  calculator  2  times and  find a  second result.  
///   Try to  find the  Greatest Common  Divisor(Largest Positive Integer thatdivides each of the integers) from the 2 results.
///   Test Example 24, 28, GCD = 4
///5. Based on the 2nd result find the corresponding Fibonacci Number.
///   For example if the result is 13 find the 13th Fibonacci Number.
///6. Is the result a Fibonacci Number???

[assembly: InternalsVisibleTo("Project2aTests")]
namespace Project2a
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoNumbersCalculator twoNumbersCalculator1 = new TwoNumbersCalculator();
            TwoNumbersCalculator twoNumbersCalculator2 = new TwoNumbersCalculator();

            // 1.Ask user to enter two numbers and a symbol
            int result1 = twoNumbersCalculator1.GetTwoNumbersCalculation();
            
            // 2.Based on symbol choice calculate and print the result.
            Console.WriteLine(twoNumbersCalculator1);
            
            // 4.Use the  calculator  2  times and  find a  second result
            int result2 = twoNumbersCalculator2.GetTwoNumbersCalculation();
            //   print result2
            Console.WriteLine(twoNumbersCalculator2);
            
            //   Try to  find the  Greatest Common  Divisor
            Console.WriteLine($"GreatestCommonDivisor for the results {result1}, {result2} is {MyMath.GreatestCommonDivisor(result1,result2)}");

            // 3. Check if the 2nd result is a prime number
            try
            {
                string isPrimeMessage = MyMath.IsPrime(result2) ? "" : "not ";
                Console.WriteLine($"The number {result2} is {isPrimeMessage}a prime number.");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message + " (" + e.ParamName + ")");
            }

            // 5. Based on the 2nd result find the corresponding Fibonacci Number
            try
            {
                long fibonacci = MyMath.Fibonacci(result2);
                Console.WriteLine($"The {result2}nth Fibonacci number is {fibonacci}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message + " (" + e.ParamName + ")");
            }

            // 6.Is the result a Fibonacci Number ???
            try
            {
                string isFibonacciMessage = MyMath.IsFibonacciNumber(result2) ? "" : "not ";
                Console.WriteLine($"The number {result2} is {isFibonacciMessage}a Fibonacci number.");
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine(e.Message + " (" + e.ParamName + ")");
            }
            

            Console.ReadLine();

        }
    }
}
