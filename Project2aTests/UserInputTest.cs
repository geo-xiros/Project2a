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
        public void TestMethod1()
        {
            FakeInputMethod fakeInputMethod = new FakeInputMethod(new List<string> { "1", "2", "+" });
            UserInputNumber userInputNumber = new UserInputNumber(fakeInputMethod.GetInput);
            UserInputOperator userInputOperator = new UserInputOperator(fakeInputMethod.GetInput);

            Assert.AreEqual(true, userInputNumber.GetInputNumber("get a number:", out int number1));
            Assert.AreEqual(1, number1);

            Assert.AreEqual(true, userInputNumber.GetInputNumber("get a number:", out int number2));
            Assert.AreEqual(2, number2);

            Assert.AreEqual(true, userInputOperator.GetInputOperator("get an operator:", out string calculateOperator));
            Assert.AreEqual("+", calculateOperator);
                        
        }
    }
}
