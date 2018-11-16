using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    static public class MyMath
    {
        static public int Fibonacci(int number)
        {
            if (number< 0)
            {
                throw new ArgumentOutOfRangeException("number", "Parameters can not be negatives.");
            }

            int a = 0;
            int b = 1;
            for (; number>0;number--)
            {
                int c = b;
                b += a;
                a = c;
            }
            return a ;
        }
        static public bool IsFibonacciNumber(int number)
        {
            int a = 0;
            int b = 1;
            for (; a <number ; )
            {
                int c = b;
                b += a;
                a = c;
            }
            return a==number;
        }

        static public int GreatestCommonDivisor(int number1, int number2)
        {
            if (number1 == 0)
            {
                return number2;
            }

            if (number2 == 0)
            {
                return number1;
            }

            return GreatestCommonDivisor(number2, number1 % number2);
        }
        static public bool IsPrime(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "IsPrime method is working only for positive numbers.");
            }

            if (number < 2)
            {
                return false;
            }

            int uplimit = ((int)Math.Sqrt(number)) + 1;
            for (int divisor = 2; divisor < uplimit; divisor++)
            {
                if ((number % divisor) == 0)
                {
                    return false;
                }

            }
            return true;
        }

    }
}
