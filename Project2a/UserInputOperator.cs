using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class UserInputOperator : UserInput
    {
        public UserInputOperator() : base(Console.ReadLine) { }

        public bool GetInputOperator(string message, out string calculateOperator)
        {
            throw new NotImplementedException();
        }
    }
}
