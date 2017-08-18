using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorManagerTests
    {

        [TestMethod]
        public void TestAddWithOneFLoat()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 5f;
            var result = calcManager.Add(5f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddWithTwoFloats()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 8f;
            var result = calcManager.Add(4f, 4f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddWithThreeFloats()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 10f;
            var result = calcManager.Add(3f, 5f, 2f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubstractWithOneFloat()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = -1;
            var result = calcManager.Substract(-1);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubstractWithTwoFloat()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = -2;
            var result = calcManager.Substract(5f, 7f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubstractWithTwoFloatsWhereTheLastIsNegative()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 10f;
            var result = calcManager.Substract(5f, -5f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubstractWithFiveFloats()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = -2f;
            var result = calcManager.Substract(2f, -7f, 6f, 4f, 1f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDivideWithZero()
        {
            var calcManager = new CalculatorManager();
            calcManager.Divide(7f, 0f);
        }

        [TestMethod]
        public void TestDivideTwoFloats()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 5f;
            var result = calcManager.Divide(10f, 2f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivideWithNotNaturalFloats()
        {
            var calcManager = new CalculatorManager();
            var expectedResult = 3.125f;
            var result = calcManager.Divide(7.5f, 2.4f);

            Assert.AreEqual(expectedResult, result, 0.001f);
        }
    }
}
