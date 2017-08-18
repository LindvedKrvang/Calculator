using System;
using System.Linq;

namespace Calculator
{
    public class CalculatorManager
    {
        public float Add(params float[] numbers)
        {
            return numbers.Sum();
        }

        public float Substract(params float[] numbers)
        {
            var result = numbers[0];
            for (var i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public float Divide(float dividend, float divisor)
        {
            if (divisor == 0)
            {
                throw new InvalidOperationException("Can't divide with zero!");
            }

            return dividend / divisor;
        }
    }
}