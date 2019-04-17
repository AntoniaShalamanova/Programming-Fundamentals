using System;

namespace P3PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            PrintTriangle(size);
        }

        static void PrintTriangle(int size)
        {
            PrintFirstHalf(size);
            PrintSecondtHalf(size);
        }

        static void PrintFirstHalf(int size)
        {
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintSecondtHalf(int size)
        {
            for (int row = size - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
