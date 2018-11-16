using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Project2a
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath.IsPrime(2);
            TwoNumbersCalculator twoNumbersCalculator1 = new TwoNumbersCalculator();
            TwoNumbersCalculator twoNumbersCalculator2 = new TwoNumbersCalculator();

            int result1 = twoNumbersCalculator1.GetTwoNumbersCalculation(); Console.WriteLine(result1);
            int result2 = twoNumbersCalculator2.GetTwoNumbersCalculation(); Console.WriteLine(result2);

            int fibonacci = MyMath.Fibonacci(result2);
            Console.WriteLine($"Fibonacci({result2}) = {fibonacci}");

            Console.WriteLine($"IsFibonacciNumber({result2}) = {MyMath.IsFibonacciNumber(result2)}");

            Console.ReadLine();

        }
    }
}
