using System;
using System.Linq;

namespace P3FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;
            int[] upLine = new int[2 * k];
            int[] downLine = new int[2 * k];
            int[] sum = new int[2 * k];


            int j = 0;
            for (int i = k - 1; i >= 0; i--)
            {
                upLine[j] = numbers[i];
                j++;
            }

            int m = 0;
            for (int i = k; i < k * 3; i++)
            {
                downLine[m] = numbers[i];
                m++;
            }

            for (int i = numbers.Length - 1; i >= numbers.Length - k; i--)
            {
                upLine[j] = numbers[i];
                j++;
            }

            for (int i = 0; i < downLine.Length; i++)
            {
                sum[i] = upLine[i] + downLine[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
