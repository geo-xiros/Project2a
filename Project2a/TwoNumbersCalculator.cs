using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class TwoNumbersCalculator
    {
        private UserInputNumber _userInputNumber;
        private UserInputOperator _userInputOperator;
        private int _number1;
        private int _number2;
        private int _result;
        private string _calculationOperator;

        public TwoNumbersCalculator() : this(new UserInputNumber(), new UserInputOperator()) { }
        public TwoNumbersCalculator(UserInputNumber userInputNumber, UserInputOperator userInputOperator)
        {
            _userInputNumber = userInputNumber;
            _userInputOperator = userInputOperator;
        }
        public int GetTwoNumbersCalculation()
        {

            _number1 = GetANumber("Give First Number:");
            _number2 = GetANumber("Give Second Number:");

            _calculationOperator = GetAnOperator($"Get calculation operator ({Calculator.Operators()}):");

            while (_calculationOperator == "/" && _number2 == 0)
            {
                Console.WriteLine("Can not divide by zero.");
                _number2 = GetANumber("Give a Second Number :");
            }

            _result= Calculator.Calculate(_calculationOperator, _number1, _number2);
            return _result;

        }
        public override string ToString()
        {
            return $"{_number1} {_calculationOperator} {_number2} = {_result}";
        }

        private int GetANumber(string inputMessage)
        {
            int number;
            while (!_userInputNumber.GetInputNumber(inputMessage, out number))
            {
                Console.WriteLine("Invalid number !!!");
            }
            return number;
        }
        private string GetAnOperator(string inputMessage)
        {
            string calculationOperator;
            while (!_userInputOperator.GetInputOperator(inputMessage, out calculationOperator) ||
                   !Calculator.IsValidOperator(calculationOperator))
            {
                Console.WriteLine("Invalid operator !!!");
            }
            return calculationOperator;
        }

    }
}
