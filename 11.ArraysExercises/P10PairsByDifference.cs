using System;
using System.Linq;

namespace P10PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int pairsCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == diff)
                    {
                        pairsCount++;
                    }
                }
            }

            Console.WriteLine(pairsCount);
        }
    }
}
