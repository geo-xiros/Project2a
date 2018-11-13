using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    public class UserInputOperator : UserInput
    {
        public UserInputOperator() : this(Console.ReadLine) { }
        public UserInputOperator(GetInput inputMethod) : base(inputMethod) { }

        public bool GetInputOperator(string message, out string calculateOperator)
        {
            Console.Write(message);
            calculateOperator = _inputMethod();
            return true;
        }
    }
}
