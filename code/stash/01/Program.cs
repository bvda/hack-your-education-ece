using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      var fb = new FizzBuzz01();
      var result = fb.Calculate(100);
    }
  }
}
