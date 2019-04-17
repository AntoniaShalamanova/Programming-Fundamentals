using System;
using System.Linq;

namespace P6MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lastNUmber = 0;
            int currentSequenceLength = 1;
            int longestSequenceNumber = 0;
            int longestSequenceLength = 0;

            for (int currentNumber = 1; currentNumber < numbers.Length; currentNumber++)
            {
                if (numbers[currentNumber] == numbers[lastNUmber])
                {
                    currentSequenceLength++;
                }
                else
                { 
                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        longestSequenceNumber = numbers[lastNUmber];
                    }

                    currentSequenceLength = 1;
                }

                lastNUmber = currentNumber;
            }

            if (currentSequenceLength > longestSequenceLength)
            {
                longestSequenceLength = currentSequenceLength;
                longestSequenceNumber = numbers[lastNUmber];
            }

            for (int i = 0; i < longestSequenceLength; i++)
            {
                Console.Write(longestSequenceNumber + " ");
            }
        }
    }
}
