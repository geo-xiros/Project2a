using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class UserInputNumber : UserInput
    {
        public UserInputNumber() : base(Console.ReadLine) { }

        public bool GetInputNumber(string message, out int number)
        {
            throw new NotImplementedException();
        }
    }
}
