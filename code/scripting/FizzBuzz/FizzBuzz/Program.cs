using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = Int32.Parse(args[0]);
            int end = Int32.Parse(args[1]);
            int fizz = Int32.Parse(args[2]);
            int buzz = Int32.Parse(args[3]);

            IEnumerable<int> range = Enumerable.Range(start, end);
            foreach(var i in range) {
                if(i % fizz == 0 && i % buzz == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if(i % fizz != 0 && i % buzz != 0) {
                    Console.WriteLine(i);
                } else if(i % fizz == 0) {
                    Console.WriteLine("Fizz");
                } else if(i % buzz == 0) {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
