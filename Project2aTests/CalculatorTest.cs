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
            Calculator<int> calculator = Calculator<int>.CreateIntCalculator();
            Assert.AreEqual(15, calculator.Calculate("+", 5, 10));
            Assert.AreEqual(5, calculator.Calculate("-", 15, 10));
            Assert.AreEqual(5, calculator.Calculate("/", 10, 2));
            Assert.AreEqual(100, calculator.Calculate("*", 10, 10));
            Assert.AreEqual(2, calculator.Calculate("%", 8, 3));
            Assert.AreEqual(2, calculator.Calculate("sqrt", 4, 2));
        }
        [TestMethod]
        public void IsValidOperatorShouldReturnTrue()
        {
            Calculator<int> calculator = Calculator<int>.CreateIntCalculator();
            Assert.AreEqual(true, calculator.IsValidOperator("+"));
            Assert.AreEqual(true, calculator.IsValidOperator("-"));
            Assert.AreEqual(true, calculator.IsValidOperator("/"));
            Assert.AreEqual(true, calculator.IsValidOperator("*"));
            Assert.AreEqual(true, calculator.IsValidOperator("sqrt"));
        }
        [TestMethod]
        public void IsValidOperatorShouldReturnFalse()
        {
            Calculator<int> calculator = Calculator<int>.CreateIntCalculator();
            Assert.AreEqual(false, calculator.IsValidOperator("."));
            Assert.AreEqual(false, calculator.IsValidOperator("y"));
            Assert.AreEqual(false, calculator.IsValidOperator("a"));
            Assert.AreEqual(false, calculator.IsValidOperator("z"));
            Assert.AreEqual(false, calculator.IsValidOperator("xxx"));
        }
        [TestMethod]
        public void TestAddingOperator()
        {
            Calculator<int> calculator = Calculator<int>.CreateIntCalculator();
            calculator.AddOperator("add", (n1, n2) => n1 + n2);
            Assert.AreEqual(3, calculator.Calculate("add", 1, 2));
        }
        [TestMethod]
        public void TestGettingOperators()
        {
            Calculator<int> calculator = Calculator<int>.CreateIntCalculator();
            calculator.AddOperator("add", (n1, n2) => n1 + n2);
            Assert.AreEqual("+, -, /, *, %, sqrt, add", calculator.Operators());
        }

        [TestMethod]
        public void OperatorsOverloading()
        {
            Calculator<int> calculator = new Calculator<int>();
            calculator.AddOperator("add", (n1, n2) => n1 + n2);
            calculator.AddOperator("sub", (n1, n2) => n1 - n2);
            calculator.AddOperator("div", (n1, n2) => n1 / n2);
            calculator.AddOperator("mul", (n1, n2) => n1 * n2);

            Assert.AreEqual(15, calculator.Calculate("add", 5, 10));
            Assert.AreEqual(5, calculator.Calculate("sub", 15, 10));
            Assert.AreEqual(5, calculator.Calculate("div", 10, 2));
            Assert.AreEqual(100, calculator.Calculate("mul", 10, 10));
        }
    }
}
