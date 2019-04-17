using System;
using System.Numerics;

namespace P14FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CountsTrailingZeroes(number));
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int CountsTrailingZeroes(int number)
        {
            BigInteger factorial = CalculateFactorial(number);
            int countTrailingZeroes = 0;

            while (factorial % 10 == 0)
            {
                countTrailingZeroes++;
                factorial /= 10;
            }

            return countTrailingZeroes;
        }
    }
}
