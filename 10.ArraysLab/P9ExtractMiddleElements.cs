using System;
using System.Linq;

namespace P9ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sizeOfMiddleElements = 0;

            if (numbers.Length == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }
            else if (numbers.Length % 2 == 0)
            {
                sizeOfMiddleElements = 2;
                Console.WriteLine(GetMiddleElements(numbers, sizeOfMiddleElements));
            }
            else if (numbers.Length % 2 != 0)
            {
                sizeOfMiddleElements = 3;
                Console.WriteLine(GetMiddleElements(numbers, sizeOfMiddleElements));
            }
        }

        static string GetMiddleElements(int[] numbers, int sizeOfMiddleElements)
        {
            int startIndx = (numbers.Length - sizeOfMiddleElements) / 2;
            int endIndx = startIndx + sizeOfMiddleElements - 1;
            int[] middleElements = new int[sizeOfMiddleElements];

            for (int i = startIndx; i <= endIndx; i++)
            {
                middleElements[i - startIndx] = numbers[i];
            }

            string middleElementsString = string.Join(", ", middleElements);
            middleElementsString = string.Format("{{ {0} }}", middleElementsString); 
            return middleElementsString;
        }
    }
}
