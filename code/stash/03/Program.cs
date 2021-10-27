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
            var fb = new FizzBuzz03();
            fb.Print(fb.Calculate(0, 100));
        }
    }
}
