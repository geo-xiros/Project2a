using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2a;

namespace Project2aTests
{
    [TestClass]
    public class TwoNumbersCalculatorTest

    {
        [TestMethod]
        public void GetTwoNumbersCalculationShouldReturnCalculations()
        {
            UserInputNumber fakeUserInputNumber = new UserInputNumber(new FakeInputMethod("5,5,10,5,2,6,yy,6,2").GetInput);
            UserInputOperator fakeUserInputOperator = new UserInputOperator(new FakeInputMethod("+,-,*,xx,/").GetInput, Calculator.IsValidOperator);

            TwoNumbersCalculator twoNumbersCalculator = new TwoNumbersCalculator(fakeUserInputNumber, fakeUserInputOperator);
            Assert.AreEqual(10, twoNumbersCalculator.GetTwoNumbersCalculation());
            Assert.AreEqual(5, twoNumbersCalculator.GetTwoNumbersCalculation());
            Assert.AreEqual(12, twoNumbersCalculator.GetTwoNumbersCalculation());
            Assert.AreEqual(3, twoNumbersCalculator.GetTwoNumbersCalculation());

        }
        [TestMethod]
        public void ToStringShouldReturnCalculations()
        {
            UserInputNumber fakeUserInputNumber = new UserInputNumber(new FakeInputMethod("5,5,10,5,2,6,6,2,8,5,4,2").GetInput);
            UserInputOperator fakeUserInputOperator = new UserInputOperator(new FakeInputMethod("+,-,*,/,%,sqrt").GetInput, Calculator.IsValidOperator);

            TwoNumbersCalculator twoNumbersCalculator = new TwoNumbersCalculator(fakeUserInputNumber, fakeUserInputOperator);
            twoNumbersCalculator.GetTwoNumbersCalculation();
            Assert.AreEqual("5 + 5 = 10", twoNumbersCalculator.ToString());
            twoNumbersCalculator.GetTwoNumbersCalculation();
            Assert.AreEqual("10 - 5 = 5", twoNumbersCalculator.ToString());
            twoNumbersCalculator.GetTwoNumbersCalculation();
            Assert.AreEqual("2 * 6 = 12", twoNumbersCalculator.ToString());
            twoNumbersCalculator.GetTwoNumbersCalculation();
            Assert.AreEqual("6 / 2 = 3", twoNumbersCalculator.ToString());
            twoNumbersCalculator.GetTwoNumbersCalculation();
            Assert.AreEqual("8 % 5 = 3", twoNumbersCalculator.ToString());
            twoNumbersCalculator.GetTwoNumbersCalculation();
            Assert.AreEqual("Squear root of 4 is 2", twoNumbersCalculator.ToString());

        }
    }
}
