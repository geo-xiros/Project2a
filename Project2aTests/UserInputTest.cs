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
        public void TestInputNumber()
        {
            FakeInputMethod fakeInputMethod = new FakeInputMethod( "5,6");

            UserInputNumber userInputNumber = new UserInputNumber(fakeInputMethod.GetInput);
            int number1;
            Assert.AreEqual(true, userInputNumber.GetInputNumber("get a number:", out number1));
            Assert.AreEqual(5, number1);
            int number2;
            Assert.AreEqual(true, userInputNumber.GetInputNumber("get a number:", out number2));
            Assert.AreEqual(6, number2);

        }
        [TestMethod]
        public void TestInputOperator()
        {
            FakeInputMethod fakeInputMethod = new FakeInputMethod("+,-,*");
            UserInputOperator userInputOperator = new UserInputOperator(fakeInputMethod.GetInput);
            string calculateOperator;
            Assert.AreEqual(true, userInputOperator.GetInputOperator("get an operator:", out calculateOperator));
            Assert.AreEqual("+", calculateOperator);

            Assert.AreEqual(true, userInputOperator.GetInputOperator("get an operator:", out  calculateOperator));
            Assert.AreEqual("-", calculateOperator);

            Assert.AreEqual(true, userInputOperator.GetInputOperator("get an operator:", out  calculateOperator));
            Assert.AreEqual("*", calculateOperator);

        }
    }
}
