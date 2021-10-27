namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzz05();
            var result = fb.Calculate(0, 100);
            fb.WriteToFile(result);
        }
    }
}
