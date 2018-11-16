﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2a
{
    class UserInput
    {
        public delegate string GetInput();
        protected GetInput _inputMethod;

        public UserInput(GetInput inputMethod)
        {
            _inputMethod = inputMethod;
        }
    }
}
