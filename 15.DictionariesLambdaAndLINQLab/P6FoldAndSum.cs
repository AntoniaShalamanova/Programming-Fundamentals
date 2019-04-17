using System;
using System.Linq;

namespace P6FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] upperArr = numbers.Take(k).Reverse().ToArray();

            upperArr = upperArr.Concat(numbers.Skip(3 * k).Reverse().ToArray()).ToArray();

            int[] downArr = numbers.Skip(k).Take(2 * k).ToArray();

            int[] sum = upperArr.Select((numb, indx) => numb + downArr[indx]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
