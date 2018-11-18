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
    private readonly string[] _inputs;
    private int _inputIndex;
    public FakeInputMethod(string inputs)
    {
      _inputs = inputs.Split(',');
    }

    public string GetInput()
    {
      if (_inputIndex >= _inputs.Length)
      {
        _inputIndex = 0;
      }

      return _inputs[_inputIndex++].Trim();
    }
  }
}
