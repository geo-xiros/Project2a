using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    static class Calculator
    {
        public delegate int MathMethod(int number1, int number2);
        static private Dictionary<string, MathMethod> _methodsByOperator;

        static Calculator()
        {
            _methodsByOperator = new Dictionary<string, MathMethod>()
            {
                {"+", (n1,n2) => n1+n2 },
                {"-", (n1,n2) => n1-n2 },
                {"/", (n1,n2) => n1/n2 },
                {"*", (n1,n2) => n1*n2 },
                {"%", (n1,n2) => n1%n2 },
                {"sqrt", (n1,n2) => (int) Math.Sqrt(n1) }
                //{"sqrt", (n1,n2) => (int) Math.Pow((double) n1,(double) 1/n2) }
            };
        }
        static public void AddOperator(string calculateOperator, MathMethod calculationMethod)
        {
            _methodsByOperator[calculateOperator]= calculationMethod;
        }
        static public bool IsValidOperator(string calculateOperator)
        {
            return _methodsByOperator.ContainsKey(calculateOperator);
        }
        static public string Operators()
        {
            return string.Join(", ", _methodsByOperator.Select(i => i.Key).ToArray());
        }
        static public int Calculate(string calculateOperator, int number1, int number2)
        {
            MathMethod mathMethod = _methodsByOperator[calculateOperator];
            return mathMethod(number1, number2);
        }
    }
}
