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
            var FizzBuzz = new FizzBuzz02();
            FizzBuzz.Print(FizzBuzz.Calculate(100));
        }
    }
}
