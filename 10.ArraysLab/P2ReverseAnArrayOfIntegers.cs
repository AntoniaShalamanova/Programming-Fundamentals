using System;

namespace P2ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);

            foreach (int element in numbers)
            {
                Console.Write(element + " ");
            }
        }
    }
}
