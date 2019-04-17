using System;

namespace P11OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                number = int.Parse(Console.ReadLine());
                number = Math.Abs(number);

                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
            } while (number % 2 == 0);

            Console.WriteLine($"The number is: {number}");
        }
    }
}
