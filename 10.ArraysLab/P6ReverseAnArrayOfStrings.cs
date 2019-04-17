using System;
using System.Linq;

namespace P6ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            for (int currentElement = 0; currentElement < arr.Length / 2; currentElement++)
            {
                int swappedElement = arr.Length - 1 - currentElement;
                SwapElements(arr, currentElement, swappedElement);
            }

            string reversedSequence = string.Join(" ", arr);

            Console.WriteLine(reversedSequence);
        }

        static void SwapElements(string[] arr, int currentElement, int swappedElement)
        {
            string temp = arr[currentElement];
            arr[currentElement] = arr[swappedElement];
            arr[swappedElement] = temp;
        }
    }
}