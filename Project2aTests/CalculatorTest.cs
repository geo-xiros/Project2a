using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2a;

namespace Project2aTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestBasicCalculations()
        {
            Assert.AreEqual(15, Calculator.Calculate("+", 5, 10));
            Assert.AreEqual(5, Calculator.Calculate("-", 15, 10));
            Assert.AreEqual(5, Calculator.Calculate("/", 10, 2));
            Assert.AreEqual(100, Calculator.Calculate("*", 10, 10));
            Assert.AreEqual(2, Calculator.Calculate("%", 8, 3));
            Assert.AreEqual(2, Calculator.Calculate("sqrt", 4, 2));

        }
    }
}
