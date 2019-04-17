using System;

namespace P12NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;

            while (true)
            {
                try
                {
                    number = double.Parse(Console.ReadLine());
                    break;
                }
                catch (global::System.Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine("It is a number.");
        }
    }
}
