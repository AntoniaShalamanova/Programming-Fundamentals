using System;

namespace P2CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.PI * Math.Pow(radius, 2):F12}");
        }
    }
}
