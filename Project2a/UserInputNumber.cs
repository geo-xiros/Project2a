using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class UserInputNumber : UserInput
    {
        public UserInputNumber() : this(Console.ReadLine) { }
        public UserInputNumber(GetInput inputMethod) : base(inputMethod) { }

        public bool GetInputNumber(string message, out int number)
        {
            Console.Write(message);
            string input = _inputMethod();
            return int.TryParse(input, out number);
        }
    }
}
