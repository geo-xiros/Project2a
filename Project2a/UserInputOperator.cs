using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class UserInputOperator : UserInput<string>
    {
        public UserInputOperator(GetInput inputMethod)
        {
            _inputMethod = inputMethod;
        }
        public override bool IsValidInput(string input, out string calculateOperator)
        {
            calculateOperator = input;
            return true;
        }
    }
}
