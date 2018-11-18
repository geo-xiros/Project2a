using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class Calculator<T>
    {
        //public delegate T MathMethod(T number1, T number2);
        private Dictionary<string, Func<T, T, T>> _methodsByOperator;
        public Calculator()
        {
            _methodsByOperator = new Dictionary<string, Func<T, T, T>>();
        }
        public static Calculator<int> CreateIntCalculator()
        {
            Calculator<int> calcInt = new Calculator<int>();
            calcInt.AddOperator("+", (a, b) => a + b);
            calcInt.AddOperator("-", (a, b) => a - b);
            calcInt.AddOperator("/", (a, b) => a / b);
            calcInt.AddOperator("*", (a, b) => a * b);
            calcInt.AddOperator("%", (a, b) => a % b);
            calcInt.AddOperator("sqrt", (a, b) => (int)Math.Sqrt(a));
            return calcInt;
        }
        public static Calculator<float> CreateFloatCalculator()
        {
            Calculator<float> calcFloat = new Calculator<float>();
            calcFloat.AddOperator("+", (a, b) => a + b);
            calcFloat.AddOperator("-", (a, b) => a - b);
            calcFloat.AddOperator("/", (a, b) => a / b);
            calcFloat.AddOperator("*", (a, b) => a * b);
            calcFloat.AddOperator("%", (a, b) => a % b);
            calcFloat.AddOperator("sqrt", (a, b) => (float)Math.Sqrt(a));
            return calcFloat;
        }
        public void AddOperator(string calculateOperator, Func<T, T, T> calculationMethod)
        {
            _methodsByOperator[calculateOperator] = calculationMethod;
        }
        public bool IsValidOperator(string calculateOperator)
        {
            return _methodsByOperator.ContainsKey(calculateOperator);
        }
        public string Operators()
        {
            return string.Join(", ", _methodsByOperator.Select(i => i.Key).ToArray());
        }
        public T Calculate(string calculateOperator, T number1, T number2)
        {
            Func<T, T, T> mathMethod = _methodsByOperator[calculateOperator];
            return mathMethod(number1, number2);
        }
    }
}
