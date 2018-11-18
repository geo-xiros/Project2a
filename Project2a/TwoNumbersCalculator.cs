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
        private Calculator<int> _calculator;
        public TwoNumbersCalculator()
        {
            //   : this(new UserInputNumber(Console.ReadLine), new UserInputOperator(Console.ReadLine, Calculator.IsValidOperator)) { }
            _calculator = Calculator<int>.CreateIntCalculator();
            _userInputNumber = new UserInputNumber(Console.ReadLine);
            _userInputOperator = new UserInputOperator(Console.ReadLine, _calculator.IsValidOperator);

        }
        public TwoNumbersCalculator(UserInputNumber userInputNumber, UserInputOperator userInputOperator)
        {
            _calculator = Calculator<int>.CreateIntCalculator();
            _userInputNumber = userInputNumber;
            _userInputOperator = userInputOperator;
        }
        public int GetTwoNumbersCalculation()
        {

            GetANumber("Give First Number:", out _number1);

            GetAnOperator($"Get calculation operator ({_calculator.Operators()}):");

            // TODO 
            // αυτο το if δεν μου αρεσει καθολου...
            if (_calculationOperator != "sqrt")
            {
                GetANumber("Give Second Number:", out _number2);

                while ((_calculationOperator == "/" || _calculationOperator == "%") && _number2 == 0)
                {
                    Console.WriteLine("Can not divide by zero.");
                    GetANumber("Give a Second Number :", out _number2);
                }
            }

            _result = _calculator.Calculate(_calculationOperator, _number1, _number2);
            return _result;

        }

        private void GetANumber(string inputMessage, out int number)
        {
            while (!_userInputNumber.GetInput(inputMessage, out number))
            {
                Console.WriteLine("Invalid number !!!");
            }
        }
        private void GetAnOperator(string inputMessage)
        {
            while (!_userInputOperator.GetInput(inputMessage, out _calculationOperator))
            {
                Console.WriteLine("Invalid operator !!!");
            }
        }
        public override string ToString()
        {
            if (_calculationOperator == "sqrt")
            {
                return $"Squear root of {_number1} is {_result}";
            }
            else
            {
                return $"{_number1} {_calculationOperator} {_number2} = {_result}";
            }

        }

    }
}
