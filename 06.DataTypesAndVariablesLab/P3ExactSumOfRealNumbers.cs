using System;

namespace P3ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumber = int.Parse(Console.ReadLine());

            decimal number = 0;
            decimal sum = 0;

            for (int i = 0; i < numNumber; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
