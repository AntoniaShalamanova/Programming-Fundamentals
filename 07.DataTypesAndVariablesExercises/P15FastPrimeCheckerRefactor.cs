using System;

namespace P15FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= size; currentNumber++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor <= Math.Sqrt(currentNumber); divisor++)
                {
                    if (currentNumber % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }

        }
    }
}
