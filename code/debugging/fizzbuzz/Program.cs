﻿namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzz05();
            var result = fb.Calculate(0, 1000, 7, 9);
            fb.WriteToFile(result);
        }
    }
}
