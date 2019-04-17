using System;
using System.Linq;
using System.Collections.Generic;

namespace P1MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int currentSequenceLength = 1;
            int maxSequenceLength = 0;
            int maxSequenceNumber = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequenceLength++;
                }
                else
                {
                    if (currentSequenceLength > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceLength;
                        maxSequenceNumber = numbers[i - 1];
                    }

                    currentSequenceLength = 1;
                }
            }

            if (currentSequenceLength > maxSequenceLength)
            {
                maxSequenceLength = currentSequenceLength;
                maxSequenceNumber = numbers[numbers.Count - 1];
            }

            for (int i = 0; i < maxSequenceLength; i++)
            {
                Console.Write(maxSequenceNumber + " ");
            }
        }
    }
}
