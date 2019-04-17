using System;
using System.Linq;
using System.Collections.Generic;

namespace P3TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            foreach (var badWord in bannedWords)
            {
                text = text.Replace(badWord, new string('*', badWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
