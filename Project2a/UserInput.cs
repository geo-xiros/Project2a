using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    abstract class UserInput<T>
    {
        public delegate string GetInput();
        protected GetInput _inputMethod;

        public bool GetUserInput(string message, out T output)
        {
            Console.Write(message);
            string input = _inputMethod();
            return IsValidInput(input, out output);
        }
        public abstract bool IsValidInput(string input, out T output);
    }
}
