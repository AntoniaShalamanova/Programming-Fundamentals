using System;
using System.Collections.Generic;

namespace P7PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            List<int> primeNumbers = GetPrimeNumbers(beginNumber, endNumber);
            string result = string.Join(", ", primeNumbers);
            Console.WriteLine(result);
        }

        static List<int> GetPrimeNumbers(int beginNumber, int endNumber)
        {
            List<int> primeNumbers = new List<int>();

            for (int currentNumber = beginNumber; currentNumber <= endNumber; currentNumber++)
            {
                bool isPrime = true;

                if (currentNumber == 0 || currentNumber == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int divisor = 2; divisor <= Math.Sqrt(currentNumber); divisor++)
                    {
                        if (currentNumber % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(currentNumber);
                }
            }

            return primeNumbers;
        }
    }
}