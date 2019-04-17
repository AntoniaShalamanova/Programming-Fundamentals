using System;
using System.Linq;

namespace P11EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool haveEqualSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int k = i+1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    haveEqualSum = true;
                }
                leftSum = 0;
                rightSum = 0;
            }

            if (!haveEqualSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
