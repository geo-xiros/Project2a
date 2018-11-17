﻿using System;
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

        public TwoNumbersCalculator() : this(new UserInputNumber(Console.ReadLine), new UserInputOperator(Console.ReadLine, Calculator.IsValidOperator)) { }
        public TwoNumbersCalculator(UserInputNumber userInputNumber, UserInputOperator userInputOperator)
        {
            _userInputNumber = userInputNumber;
            _userInputOperator = userInputOperator;
        }
        public int GetTwoNumbersCalculation()
        {

            _number1 = GetANumber("Give First Number:");

            _calculationOperator = GetAnOperator($"Get calculation operator ({Calculator.Operators()}):");

            if (_calculationOperator != "sqrt")
            {
                _number2 = GetANumber("Give Second Number:");

                while (_calculationOperator == "/" && _number2 == 0)
                {
                    Console.WriteLine("Can not divide by zero.");
                    _number2 = GetANumber("Give a Second Number :");
                }
            }

            _result = Calculator.Calculate(_calculationOperator, _number1, _number2);
            return _result;

        }

        private int GetANumber(string inputMessage)
        {
            int number;
            while (!_userInputNumber.GetInput(inputMessage, out number))
            {
                Console.WriteLine("Invalid number !!!");
            }
            return number;
        }
        private string GetAnOperator(string inputMessage)
        {
            string calculationOperator;
            while (!_userInputOperator.GetInput(inputMessage, out calculationOperator))
            {
                Console.WriteLine("Invalid operator !!!");
            }
            return calculationOperator;
        }
        public override string ToString()
        {
            return $"{_number1} {_calculationOperator} {_number2} = {_result}";
        }

    }
}
