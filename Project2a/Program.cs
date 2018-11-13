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
            UserInputNumber userInputNumber = new UserInputNumber();
            UserInputOperator userInputOperator = new UserInputOperator();

            int number1;
            while (!userInputNumber.GetInputNumber("Get First Number:", out number1))
            {
                Console.WriteLine("Invalid number !!!");
            }

            int number2;
            while (!userInputNumber.GetInputNumber("Get Second Number:", out number2))
            {
                Console.WriteLine("Invalid number !!!");
            }

            string calculateOperator;
            while (!userInputOperator.GetInputOperator("Get Second Number:", out calculateOperator))
            {
                Console.WriteLine("Invalid operator !!!");
            }



        }
    }
}
