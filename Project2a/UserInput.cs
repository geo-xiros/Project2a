using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    public class UserInput
    {
        public delegate string GetInput();
        private GetInput _inputMethod;

        public UserInput(GetInput inputMethod)
        {
            _inputMethod = inputMethod;
        }
    }
}
