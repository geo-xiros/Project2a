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
            FakeInputMethod fakeInputMethod = new FakeInputMethod(new List<string> { "5", "6" });
            UserInputNumber userInputNumber = new UserInputNumber(fakeInputMethod.GetInput);

            Assert.AreEqual(true, userInputNumber.GetInputNumber("get a number:", out int number1));
            Assert.AreEqual(5, number1);

            Assert.AreEqual(true, userInputNumber.GetInputNumber("get a number:", out int number2));
            Assert.AreEqual(6, number2);

        }
        public void TestInputOperator()
        {
            FakeInputMethod fakeInputMethod = new FakeInputMethod(new List<string> {"+","-","*" });
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
