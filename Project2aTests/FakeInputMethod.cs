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
        public FakeInputMethod(string inputs)
        {
            _inputs= inputs.Split(',').ToList<string>();
    }

        public string GetInput()
        {
            string input = _inputs[0].Trim();
            _inputs.Remove(input);
            return input;
        }
    }
}
