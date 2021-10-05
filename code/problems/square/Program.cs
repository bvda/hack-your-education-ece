using System.IO;
using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Int32.Parse(args[0]);

            for (int row = 1; row <= size; row++) {
                for (int j = ; j <= (size+1) - row; j++) {
                    System.Console.Write("#");
                }
                System.Console.WriteLine("");
            }
        }
    }
}
