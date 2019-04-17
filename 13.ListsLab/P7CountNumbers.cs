using System;
using System.Linq;
using System.Collections.Generic;

namespace P7CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> occurrenceNumbers = new List<int>();
            List<int> occurrencesCount = new List<int>();
            int currentNumberCount = 1;
            int currentNumber = 0;

            if (numbers.Count == 1)
            {
                Console.WriteLine($"{numbers[0]} -> 1");
                return;
            }

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        currentNumber = numbers[i];
                        occurrenceNumbers.Add(currentNumber);
                        occurrencesCount.Add(currentNumberCount);
                    }
                    else
                    {
                        currentNumber = numbers[i];
                        occurrenceNumbers.Add(currentNumber);
                        occurrencesCount.Add(currentNumberCount);
                    }
                }
                else if (numbers[i] == numbers[i + 1])
                {
                    currentNumberCount++;
                }
                else
                {
                    currentNumber = numbers[i];
                    occurrenceNumbers.Add(currentNumber);
                    occurrencesCount.Add(currentNumberCount);
                    currentNumberCount = 1;
                }
            }

            for (int i = 0; i < occurrenceNumbers.Count; i++)
            {
                Console.WriteLine($"{occurrenceNumbers[i]} -> {occurrencesCount[i]}");
            }
        }
    }
}
