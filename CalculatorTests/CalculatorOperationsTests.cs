using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorOperationsTests
    {

        [TestMethod]
        public void TestAddWithOneFLoat()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = 5f;
            var result = calculatorOperations.Add(5f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddWithTwoFloats()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = 8f;
            var result = calculatorOperations.Add(4f, 4f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddWithThreeFloats()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = 10f;
            var result = calculatorOperations.Add(3f, 5f, 2f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubstractWithOneFloat()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = -1;
            var result = calculatorOperations.Substract(-1);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubstractWithTwoFloat()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = -2;
            var result = calculatorOperations.Substract(5f, 7f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubstractWithTwoFloatsWhereTheLastIsNegative()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = 10f;
            var result = calculatorOperations.Substract(5f, -5f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubstractWithFiveFloats()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = -2f;
            var result = calculatorOperations.Substract(2f, -7f, 6f, 4f, 1f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDivideWithZero()
        {
            var calculatorOperations = new CalculatorOperations();
            calculatorOperations.Divide(7f, 0f);
        }

        [TestMethod]
        public void TestDivideTwoFloats()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = 5f;
            var result = calculatorOperations.Divide(10f, 2f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivideWithNotNaturalFloats()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = 3.125f;
            var result = calculatorOperations.Divide(7.5f, 2.4f);

            Assert.AreEqual(expectedResult, result, 0.001f);
        }

        [TestMethod]
        public void TestMultiplyTwoPositiveFloats()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = 21f;
            var result = calculatorOperations.Multiply(7, 3);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiplyFirstNegativeSecondPositive()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = -14f;
            var result = calculatorOperations.Multiply(-2f, 7f);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiplyFirstPositiveSecondNegative()
        {
            var calculatorOperations = new CalculatorOperations();
            var expectedResult = -14f;
            var result = calculatorOperations.Multiply(2f, -7f);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
