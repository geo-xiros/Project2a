using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class UserInputOperator : UserInput<string>
    {
        private readonly Func<string, bool> _isValidOperator;
        public UserInputOperator(Func<string> inputMethod, Func<string, bool> isValidOperator)
        {
            _inputMethod = inputMethod;
            _isValidOperator = isValidOperator;
        }
        public override bool TryParse(string input, out string calculateOperator)
        {
            calculateOperator = input;
            return _isValidOperator(calculateOperator);
        }
    }
}
