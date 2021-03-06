﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    static class MyMath
    {
        static public long Fibonacci(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Fibonacci parameters can not be negatives.");
            }

            long a = 0;
            long b = 1;
            for (; number > 0; number--)
            {
                long c = b;
                b += a;
                a = c;
            }
            return a;
        }
        static public bool IsFibonacciNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "IsFibonacciNumber parameters can not be negatives.");
            }
            long a = 0;
            long b = 1;
            for (; a < number;)
            {
                long c = b;
                b += a;
                a = c;
            }
            return a == number;
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
