using System.Linq;

namespace Calculator
{
    public class CalculatorManager
    {
        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}