using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2a;
using System.Linq;
using System.Collections.Generic;

namespace Project2aTests
{
    [TestClass]
    public class MyMathTests
    {
        [TestMethod]
        public void IsPrimeShouldReturnTrue()
        {
            Assert.AreEqual<bool>(true, MyMath.IsPrime(2), "It should return a prime Number.");
            Assert.AreEqual<bool>(true, MyMath.IsPrime(3), "It should return a prime Number.");
            Assert.AreEqual<bool>(true, MyMath.IsPrime(5), "It should return a prime Number.");
            Assert.AreEqual<bool>(true, MyMath.IsPrime(7), "It should return a prime Number.");
            Assert.AreEqual<bool>(true, MyMath.IsPrime(193), "It should return a prime Number.");
            Assert.AreEqual<bool>(true, MyMath.IsPrime(397), "It should return a prime Number.");
            Assert.AreEqual<bool>(true, MyMath.IsPrime(491), "It should return a prime Number.");
        }

        [TestMethod]
        public void IsPrimeShouldReturnFalse()
        {
            Assert.AreEqual<bool>(false, MyMath.IsPrime(1), "It should not return a prime Number.");
            Assert.AreEqual<bool>(false, MyMath.IsPrime(4), "It should not return a prime Number.");
            Assert.AreEqual<bool>(false, MyMath.IsPrime(6), "It should not return a prime Number.");
            Assert.AreEqual<bool>(false, MyMath.IsPrime(10), "It should not return a prime Number.");
            Assert.AreEqual<bool>(false, MyMath.IsPrime(240), "It should not return a prime Number.");
            Assert.AreEqual<bool>(false, MyMath.IsPrime(398), "It should not return a prime Number.");

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsPrimeShouldThrowArgumentOutOfRangeException()
        {
            Console.WriteLine(MyMath.IsPrime(-10));
        }
        [TestMethod]
        public void TestFibonacci()
        {
            // First 100 Fibonacci numbers
            int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89};
            for (int number = 0; number < fibonacciNumbers.Length; number++)
            {
                Assert.AreEqual(fibonacciNumbers[number], MyMath.Fibonacci(number));
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciShouldThrowArgumentOutOfRangeException()
        {
            Console.WriteLine(MyMath.Fibonacci(-1));
        }
        [TestMethod]
        public void IsFibonacciNumberShouldReturnTrue()
        {
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(0));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(1));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(1));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(2));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(3));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(5));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(8));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(13));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(21));
            Assert.AreEqual(true, MyMath.IsFibonacciNumber(34));
        }

        [TestMethod]
        public void IsFibonacciNumberShouldReturnFalse()
        {
            Assert.AreEqual(false, MyMath.IsFibonacciNumber(4));
            Assert.AreEqual(false, MyMath.IsFibonacciNumber(6));
            Assert.AreEqual(false, MyMath.IsFibonacciNumber(7));
            Assert.AreEqual(false, MyMath.IsFibonacciNumber(9));
            Assert.AreEqual(false, MyMath.IsFibonacciNumber(10));
            Assert.AreEqual(false, MyMath.IsFibonacciNumber(11));
            Assert.AreEqual(false, MyMath.IsFibonacciNumber(12));
        }
        [TestMethod]
        public void TestGreatestCommonDivisor()
        {
            // list of Greatest Common Divisors for Pair of numbers 
            var gcdNumbers = new Dictionary<int, int[]>()
            {
                {4, new int[2]{ 0, 4 } },
                {8, new int[2]{ 8, 0 } },
                {4, new int[2]{ 12, 56 } },
                {6, new int[2]{ 18, 60 } },
                {3, new int[2]{ 234, 555 } },
                {40, new int[2]{ 120, 320 } }
            };

            foreach(var gcd in gcdNumbers)
            {
                int[] numbersToTest = gcd.Value;
                Assert.AreEqual(gcd.Key, MyMath.GreatestCommonDivisor(numbersToTest[0],numbersToTest[1]));
            }
        }

    }
}
