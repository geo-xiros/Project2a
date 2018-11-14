using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = GetTwoNumbersCalculation();
            Console.WriteLine(result1);
            int result2 = GetTwoNumbersCalculation();
            Console.WriteLine(result2);
            Console.ReadLine();

        }
        public static int GetTwoNumbersCalculation()
        {
            UserInputNumber userInputNumber = new UserInputNumber();
            UserInputOperator userInputOperator = new UserInputOperator();

            int number1 = GetANumber(userInputNumber, "Give First Number:");
            int number2 = GetANumber(userInputNumber, "Give Second Number:");
            string calculateOperator = GetAnOperator(userInputOperator, $"Get calculation operator ({Calculator.Operators()}):");

            while (calculateOperator == "/" && number2 == 0)
            {
                Console.WriteLine("Can not divide by zero.");
                number2 = GetANumber(userInputNumber, "Give a Second Number :");
            }

            return Calculator.Calculate(calculateOperator, number1, number2);

        }
        static int GetANumber(UserInputNumber userInputNumber, string inputMessage)
        {
            int number;
            while (!userInputNumber.GetInputNumber(inputMessage, out number))
            {
                Console.WriteLine("Invalid number !!!");
            }
            return number;
        }
        static string GetAnOperator(UserInputOperator userInputOperator, string inputMessage)
        {
            string calculateOperator;
            while (!userInputOperator.GetInputOperator(inputMessage, out calculateOperator) ||
                   !Calculator.IsValidOperator(calculateOperator))
            {
                Console.WriteLine("Invalid operator !!!");
            }
            return calculateOperator;
        }
    }
}
