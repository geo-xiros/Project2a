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
            if (number == 0) return 0;
            if (number < 2) return 1;
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
        static public int GreatestCommonDivisor(int number1, int number2)
        {
            if (number1 == 0)
            {
                throw new ArgumentOutOfRangeException("number1", "Parameters can not be zero.");
            }

            if (number2 == 0)
            {
                throw new ArgumentOutOfRangeException("number2", "Parameters can not be zero.");
            }

            int modulo = number1 % number2;

            if (modulo == 0)
            {
                return number2;
            }

            return GreatestCommonDivisor(number2, modulo);
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
