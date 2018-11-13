using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    static public class Calculator
    {
        delegate int MathMethod(int number1, int Number2);
        static private Dictionary<string, MathMethod> MethodsByOperator;

        static Calculator()
        {
            throw new NotImplementedException();
        }
        static void AddOperator(string calculateOperator, MathMethod calculationMethod)
        {
            throw new NotImplementedException();
        }
        static bool IsValidOperator(string calculateOperator)
        {
            throw new NotImplementedException();
        }
        static int OperatorsCount()
        {
            throw new NotImplementedException();
        }
        static int Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
