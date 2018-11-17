using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2a;

namespace Project2aTests
{
    [TestClass]
    public class UserInputTest
    {
        [TestMethod]
        public void InputNumberShouldReturnTrue()
        {
            UserInputNumber userInputNumber = new UserInputNumber(new FakeInputMethod("55").GetInput);
            Assert.AreEqual(true, userInputNumber.GetInput("get a number:", out int number));
        }
        [TestMethod]
        public void InputNumberShouldReturnFalse()
        {
            UserInputNumber userInputNumber = new UserInputNumber(new FakeInputMethod("xxx").GetInput);
            Assert.AreEqual(false, userInputNumber.GetInput("get a number:", out int number));
        }
        [TestMethod]
        public void InputNumberShouldFillNumberWithFive()
        {
            UserInputNumber userInputNumber = new UserInputNumber(new FakeInputMethod("5").GetInput);
            userInputNumber.GetInput("get a number:", out int number);
            Assert.AreEqual(5, number);
        }

        [TestMethod]
        public void TestInputNumber()
        {
            FakeInputMethod fakeInputMethod = new FakeInputMethod("5,6");

            UserInputNumber userInputNumber = new UserInputNumber(fakeInputMethod.GetInput);
            Assert.AreEqual(true, userInputNumber.GetInput("get a number:", out int number1));
            Assert.AreEqual(5, number1);
            Assert.AreEqual(true, userInputNumber.GetInput("get a number:", out int number2));
            Assert.AreEqual(6, number2);

        }
        [TestMethod]
        public void TestInputOperator()
        {
            FakeInputMethod fakeInputMethod = new FakeInputMethod("+,-,*");
            UserInputOperator userInputOperator = new UserInputOperator(fakeInputMethod.GetInput, Calculator.IsValidOperator);
            Assert.AreEqual(true, userInputOperator.GetInput("get an operator:", out string calculateOperator));
            Assert.AreEqual("+", calculateOperator);

            Assert.AreEqual(true, userInputOperator.GetInput("get an operator:", out calculateOperator));
            Assert.AreEqual("-", calculateOperator);

            Assert.AreEqual(true, userInputOperator.GetInput("get an operator:", out calculateOperator));
            Assert.AreEqual("*", calculateOperator);

        }
    }
}
