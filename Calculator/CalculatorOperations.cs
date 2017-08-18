using System;
using System.Linq;

namespace Calculator
{
    public class CalculatorOperations
    {
        /// <summary>
        /// Adds alll the numbers given to it together.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public float Add(params float[] numbers)
        {
            return numbers.Sum();
        }

        /// <summary>
        /// Substracts all the numbers given to it.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public float Substract(params float[] numbers)
        {
            var result = numbers[0];
            for (var i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        /// <summary>
        /// Divides two numbers as long the divisor is not zero.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public float Divide(float dividend, float divisor)
        {
            if (divisor == 0)
            {
                throw new InvalidOperationException("Can't divide with zero!");
            }

            return dividend / divisor;
        }

        /// <summary>
        /// Multiply two numbers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public float Multiply(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}