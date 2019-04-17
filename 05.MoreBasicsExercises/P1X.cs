using System;

namespace P1X
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int outSpaces = 0;
            int inSpaces = size - 2;
            for (int i = 0; i < size/2; i++)
            {
                Console.WriteLine(new string(' ', outSpaces) + "x" + new string(' ', inSpaces) + "x");
                outSpaces++;
                inSpaces -= 2;
            }

            outSpaces = size / 2;
            Console.WriteLine(new string(' ', outSpaces) + "x");

            outSpaces = (size - 3) / 2;
            inSpaces = 1;
            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine(new string(' ', outSpaces) + "x" + new string(' ', inSpaces) + "x");
                outSpaces--;
                inSpaces += 2;
            }
        }
    }
}
