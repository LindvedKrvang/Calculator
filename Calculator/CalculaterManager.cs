using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class CalculaterManager
    {
        public string FindOperator(string input)
        {
            var subStrings = input.Split(' ');
            var operators = subStrings.First(s =>
                s.Equals("+") ||
                s.Equals("-") ||
                s.Equals("*") ||
                s.Equals("/"));
            return operators;
        }
    }
}