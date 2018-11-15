using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2a;
using System.Linq;

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
        public void TestFibonacci()
        {
            // First 100 Fibonacci numbers
            int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 };

            for (int number = 0; number < fibonacciNumbers.Length; number++)
            {
                Assert.AreEqual(fibonacciNumbers[number], MyMath.Fibonacci(number));
            }
        }
        //[TestMethod]
        //public void TestGreatestCommonDivisor()
        //{
        //    // list of Greatest Common Divisors for Pair of numbers 
        //    Dictionary<int, int[]> gcdNumbers = new Dictionary<int, int[]>()
        //    {
        //        {4, new int[2]{ 12, 56 } },
        //        {6, new int[2]{ 18, 60 } },
        //        {3, new int[2]{ 234, 555 } },
        //        {40, new int[2]{ 120, 320 } }
        //    };

        //    // Test FindGreatestCommonDivisor
        //    var wrongResults = gcdNumbers.Where(gcd => MathUtilities.FindGreatestCommonDivisor(gcd.Value[0], gcd.Value[1]) != gcd.Key);
        //    foreach (var wrongResult in wrongResults)
        //    {
        //        int result = MathUtilities.FindGreatestCommonDivisor(wrongResult.Value[0], wrongResult.Value[1]);
        //        Console.WriteLine($"Testing FindGreatestCommonDivisor({wrongResult.Value[0]},{wrongResult.Value[1]}) returned {result} when it should return {wrongResult.Key}.");
        //    }
        //}
    }
}
