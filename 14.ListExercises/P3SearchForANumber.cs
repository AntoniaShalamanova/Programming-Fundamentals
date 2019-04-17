using System;
using System.Linq;
using System.Collections.Generic;

namespace P3SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> manipulationNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int numberOfTakenElements = manipulationNumbers[0];
            int numberOfDeletedNumbers = manipulationNumbers[1];
            int searchedNumber = manipulationNumbers[2];

            for (int i = numbers.Count - 1; i >= numberOfTakenElements; i--)
            {
                numbers.RemoveAt(i);
            }

            for (int i = 0; i < numberOfDeletedNumbers; i++)
            {
                numbers.RemoveAt(0);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == searchedNumber)
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }

            Console.WriteLine("NO!");
        }
    }
}
