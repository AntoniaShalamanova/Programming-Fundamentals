using System;

namespace P9MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }

        static int GerSumOfOddDigits(int number)
        {
            int sum = 0;
            int lastDigit = 0;

            while (number > 0)
            {
                lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GerSumOfEvenDigits(int number)
        {
            int sum = 0;
            int lastDigit = 0;

            while (number > 0)
            {
                lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GerSumOfEvenDigits(number);
            int sumOdds = GerSumOfOddDigits(number);

            return sumEvens * sumOdds;
        }
    }
}
