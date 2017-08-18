using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorManagerTests
    {
        [TestMethod]
        public void TestFindOperaterAdd()
        {
            var manager = new CalculaterManager();
            var expectedResult = "+";
            var result = manager.FindOperator("32 + 40");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestFindOperatorSubstract()
        {
            var manager = new CalculaterManager();
            var expectedResult = "-";
            var result = manager.FindOperator("10 - 36");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestFindOperatorMultiply()
        {
            var manager = new CalculaterManager();
            var expectedResult = "*";
            var result = manager.FindOperator("3 * 5");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestFindOperatorDivision()
        {
            var manager = new CalculaterManager();
            var expectedResult = "/";
            var result = manager.FindOperator("24 / 6");

            Assert.AreEqual(expectedResult, result);
        }
    }
}
