using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
  class FizzBuzz01 : IFizzBuzz01
  {
    public FizzBuzz01() { }
    public void Calculate(int start, int end)
    {
      IEnumerable<int> range = Enumerable.Range(0, end);
      foreach (var i in range)
      {
        if (i % 3 != 0 && i % 5 != 0)
        {
          Console.WriteLine(i);
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("Fizz")
                }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Buzz");
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("FizzBuzz");
        }
      }
    }
  }
}
