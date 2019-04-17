using System;
using System.Linq;

namespace P4GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedumber = int.Parse(Console.ReadLine());

            long sum = 0;
            long lastSum = 0;
            bool isThereSearchedNumber = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchedumber)
                {
                    lastSum = sum;
                    sum += numbers[i];
                    isThereSearchedNumber = true;
                }
                else
                {
                    sum += numbers[i];
                }
            }

            if (isThereSearchedNumber)
            {
                Console.WriteLine(lastSum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
