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
        public TwoNumbersCalculator() : this(new UserInputNumber(), new UserInputOperator()) { }
        public TwoNumbersCalculator(UserInputNumber userInputNumber, UserInputOperator userInputOperator)
        {
            _userInputNumber = userInputNumber;
            _userInputOperator = userInputOperator;
        }
        public int GetTwoNumbersCalculation()
        {

            int number1 = GetANumber("Give First Number:");
            int number2 = GetANumber("Give Second Number:");
            string calculationOperator = GetAnOperator($"Get calculation operator ({Calculator.Operators()}):");

            while (calculationOperator == "/" && number2 == 0)
            {
                Console.WriteLine("Can not divide by zero.");
                number2 = GetANumber("Give a Second Number :");
            }

            return Calculator.Calculate(calculationOperator, number1, number2);

        }
        int GetANumber(string inputMessage)
        {
            int number;
            while (!_userInputNumber.GetInputNumber(inputMessage, out number))
            {
                Console.WriteLine("Invalid number !!!");
            }
            return number;
        }
        string GetAnOperator(string inputMessage)
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
