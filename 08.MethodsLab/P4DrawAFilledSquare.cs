using System;

namespace P4DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            PrintBorder(size);

            for (int row = 1; row <= size - 2; row++)
            {
                PrintMiddle(size);
            }

            PrintBorder(size);
        }

        static void PrintBorder(int size)
        {
            Console.WriteLine(new string('-', size * 2));
        }

        static void PrintMiddle(int size)
        {
            Console.Write("-");
            for (int i = 1; i < size; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
