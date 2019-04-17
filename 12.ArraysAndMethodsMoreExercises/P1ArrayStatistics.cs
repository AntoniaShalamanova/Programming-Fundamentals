using System;
using System.Linq;
using System.Collections.Generic;

namespace P1ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {GetMinNumber(numbers)}");
            Console.WriteLine($"Max = {GetMaxNumber(numbers)}");
            Console.WriteLine($"Sum = {GetSum(numbers)}");
            Console.WriteLine($"Average = {GetSum(numbers) / (numbers.Length * 1.0)}");
        }

        static long GetSum(int[] numbers)
        {
            long sum = 0;

            foreach (int numb in numbers)
            {
                sum += numb;
            }

            return sum;
        }

        static int GetMaxNumber(int[] numbers)
        {
            int maxNumber = Int32.MinValue;

            foreach (int numb in numbers)
            {
                if (numb > maxNumber)
                {
                    maxNumber = numb;
                }
            }

            return maxNumber;
        }

        static int GetMinNumber(int[] numbers)
        {
            int minNumber = Int32.MaxValue;

            foreach (int num in numbers)
            {
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }

            return minNumber;
        }
    }
}
