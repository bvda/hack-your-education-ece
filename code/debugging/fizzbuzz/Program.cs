using System;
using System.Collections.Generic;
using System.Linq;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> range = Enumerable.Range(0, Int32.Parse(args[0]));
            foreach(var i in range) {
                if(i % 3 == 0 || i % 5 == 0) {
                    Console.WriteLine("Fizz");
                }
                Console.WriteLine(i);
            }
        }
    }
}
