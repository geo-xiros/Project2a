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
        public void TestPrimeMethod()
        {
            // First 100 Prime numebrs
            int[] primeNumbers = {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97,101,103,107,109,113,127,131,137,139,149,151,157,163,167,173,179,181,191,
                                  193,197,199,211,223,227,229,233,239,241,251,257,263,269,271,277,281,283,293,307,311,313,317,331,337,347,349,353,359,367,373,379,383,389,
                                  397,401,409,419,421,431,433,439,443,449,457,461,463,467,479,487,491,499,503,509,521,523,541 };
            foreach (int number in primeNumbers)
            {
                Assert.AreEqual<bool>(true, MyMath.IsPrime(number), "It should return a prime Number.");
            }
            var notPrimeNumbers = Enumerable.Range(1, primeNumbers.Max()).Where(i => !primeNumbers.Contains(i));
            foreach (int number in notPrimeNumbers)
            {
                Assert.AreEqual<bool>(false, MyMath.IsPrime(number), "It should not return a prime Number.");
            }

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
            Console.WriteLine(MyMath.Fibonacci(100000));
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
