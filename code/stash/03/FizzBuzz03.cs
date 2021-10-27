using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class FizzBuzz03: IFizzBuzz03 
    {
        public FizzBuzz03() { }
        public IEnumerable<string> Calculate(int start, int end)
        {

            IEnumerable<int> range = Enumerable.Range(0, end);
            IList<string> result = new List<string>();
            foreach(var i in range) {
                string value = "";
                if(i % 3 != 0 && i % 5 != 0) {
                    value = i.ToString();
                } else if(i % 3 == 0) {
                    value = "Fizz";
                } else if(i % 5 == 0) {
                    value = "Buzz";
                } else if(i % 3 == 0 && i % 5 == 0) {
                    value = "FizzBuzz";
                } 
                using(var outFile = new StreamWriter("FizzBuzz.log", true)) {
                    outFile.WriteLine(value);
                }          
                result.Add(value);
            }
            return result;
        }

        public void Print(IEnumerable<string> fizzBuzz) {
          fizzBuzz.ToList().ForEach(num => Console.WriteLine(num));
        }
    }
}