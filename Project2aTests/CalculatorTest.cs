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
        [TestMethod]
        public void OperatorsOverloading()
        {
            Calculator.AddOperator("add", (n1, n2) => n1 + n2);
            Calculator.AddOperator("sub", (n1, n2) => n1 - n2);
            Calculator.AddOperator("div", (n1, n2) => n1 / n2);
            Calculator.AddOperator("mul", (n1, n2) => n1 * n2);

            Assert.AreEqual(15, Calculator.Calculate("add", 5, 10));
            Assert.AreEqual(5, Calculator.Calculate("sub", 15, 10));
            Assert.AreEqual(5, Calculator.Calculate("div", 10, 2));
            Assert.AreEqual(100, Calculator.Calculate("mul", 10, 10));
        }
    }
}
