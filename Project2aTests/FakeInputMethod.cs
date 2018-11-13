using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2a;

namespace Project2aTests
{
    class FakeInputMethod 
    {
        private List<string> _inputs;
        public FakeInputMethod(List<string> inputs)
        {
            _inputs= inputs;
    }

        public string GetInput()
        {
            string input = _inputs[0];
            _inputs.Remove(input);
            return input;
        }
    }
}
