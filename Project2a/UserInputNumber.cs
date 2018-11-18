using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class UserInputNumber : UserInput<int>
    {
        public UserInputNumber(Func<string> inputMethod)
        {
            _inputMethod = inputMethod;
        }
        public override bool TryParse(string input, out int number)
        {
            return int.TryParse(input, out number);
        }
    }
}
