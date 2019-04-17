using System;
using System.Linq;

namespace P7MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lastNUmber = 0;
            int currentSequenceLength = 1;
            int longestSequenceIndx = 0;
            int longestSequenceLength = 0;

            for (int currentNumber = 1; currentNumber < numbers.Length; currentNumber++)
            {
                if (numbers[currentNumber] > numbers[lastNUmber])
                {
                    currentSequenceLength++;
                }
                else
                {
                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        longestSequenceIndx = lastNUmber;
                    }

                    currentSequenceLength = 1;
                }

                lastNUmber = currentNumber;
            }

            if (currentSequenceLength > longestSequenceLength)
            {
                longestSequenceLength = currentSequenceLength;
                longestSequenceIndx = lastNUmber;
            }

            for (int i = longestSequenceIndx - longestSequenceLength + 1; i <= longestSequenceIndx; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
