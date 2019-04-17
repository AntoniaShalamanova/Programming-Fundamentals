using System;
using System.Linq;

namespace P9IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();

            foreach (char letter in letters)
            {
                Console.WriteLine($"{letter} -> {letter - 97}");
            }
        }
    }
}
