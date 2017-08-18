using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorManagerTests
    {

        [TestMethod]
        public void TestAddWithOneInteger()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 5;
            var result = calcManager.Add(5);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddWithTwoIntegers()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 8;
            var result = calcManager.Add(4, 4);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddWithThreeIntegers()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 10;
            var result = calcManager.Add(3, 5, 2);

            Assert.AreEqual(expectedResult, result);
        }


    }
}
