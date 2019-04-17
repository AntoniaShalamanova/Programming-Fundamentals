using System;

namespace P6PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(GetIsPrime(number));
        }

        private static bool GetIsPrime(long number)
        {
            bool isPrime = true;

            if (number == 0 || number == 1)
            {
                return isPrime = false;
            }
            else
            {
                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        return isPrime;
                    }
                }
            }

            return isPrime;
        }
    }
}
