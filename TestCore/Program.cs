using System;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine() ?? "0");
            int second = int.Parse(Console.ReadLine() ?? "0");
            int sum = first + second;
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
}
