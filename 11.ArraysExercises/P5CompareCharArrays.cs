using System;
using System.Linq;

namespace P5CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstWord = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondWord = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int minLength = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstWord[i] < secondWord[i])
                {
                    Console.WriteLine(string.Join("", firstWord));
                    Console.WriteLine(string.Join("", secondWord));
                    return;
                }
                else if (firstWord[i] > secondWord[i])
                {
                    Console.WriteLine(string.Join("", secondWord));
                    Console.WriteLine(string.Join("", firstWord));
                    return;
                }
            }

            if (firstWord.Length < secondWord.Length)
            {
                Console.WriteLine(string.Join("", firstWord));
                Console.WriteLine(string.Join("", secondWord));
            }
            else
            {
                Console.WriteLine(string.Join("", secondWord));
                Console.WriteLine(string.Join("", firstWord));
            }
        }
    }
}
