using System;
using System.Collections.Generic;
using System.Linq;

namespace P2PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int indx = 0;
            int removedElementCount = 0;
            int elementToRemove = 0;

            while (numbers.Count > 0)
            {
                indx = int.Parse(Console.ReadLine());

                if (indx < 0)
                {
                    elementToRemove = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (indx > numbers.Count - 1)
                {
                    elementToRemove = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    elementToRemove = numbers[indx];
                    numbers.RemoveAt(indx);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= elementToRemove)
                    {
                        numbers[i] += elementToRemove;
                    }
                    else
                    {
                        numbers[i] -= elementToRemove;
                    }
                }

                removedElementCount += elementToRemove;
            }

            Console.WriteLine(removedElementCount);
        }
    }
}