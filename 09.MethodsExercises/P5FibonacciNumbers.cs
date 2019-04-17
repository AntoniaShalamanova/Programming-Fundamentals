using System;

namespace P5FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacciNumber(number));
        }

        static int GetFibonacciNumber(int number)
        {
            int fibonacciNumber = 0;
            int lastFibonacci = 1;
            int lastLastFibonacci = 1;

            if (number == 0 || number == 1)
            {
                fibonacciNumber = 1;
            }
            else
            {
                for (int currentNumber = 2; currentNumber <= number; currentNumber++)
                {
                    fibonacciNumber = lastLastFibonacci + lastFibonacci;
                    lastLastFibonacci = lastFibonacci;
                    lastFibonacci = fibonacciNumber;
                }
            }

            return fibonacciNumber;
        }
    }
}
