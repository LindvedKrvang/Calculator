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
    }
}