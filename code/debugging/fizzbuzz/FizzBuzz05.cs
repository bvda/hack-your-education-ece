using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
  class FizzBuzz05 : IFizzBuzz05
  {
    public FizzBuzz05() { }
    public IEnumerable<string> Calculate(int start, int end)
    {
      IEnumerable<int> range = Enumerable.Range(0, end);
      IList<string> result = new List<string>();
      foreach (var i in range)
      {
        string value = "";
        if (i % 3 == 0 && i % 5 == 0)
        {
          value = "FizzBuzz";
        }
        else if (i % 3 != 0 && i % 5 != 0)
        {
          value = i.ToString();
        }
        else if (i % 3 == 0)
        {
          value = "Fizz";
        }
        else if (i % 5 == 0)
        {
          value = "Buzz";
        }
        result.Add(value);
      }
      return result;
    }

    public void Print(IEnumerable<string> fizzBuzz)
    {
      fizzBuzz.ToList().ForEach(num => Console.WriteLine(num));
    }

    public void WriteToFile(IEnumerable<string> list)
    {
      using (var outFile = new StreamWriter(path: "FizzBuzz.log", encoding: Encoding.UTF8, append: false))
      {
        list.ToList().ForEach(item => outFile.WriteLine(item));
      }
    }
  }
}