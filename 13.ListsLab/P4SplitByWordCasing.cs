using System;
using System.Linq;
using System.Collections.Generic;

namespace P4SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            foreach (string word in words)
            {
                if (GetUpperAndLowerSymbolsCount(word)[0] == word.Length)
                {
                    lowerCaseWords.Add(word);
                }
                else if (GetUpperAndLowerSymbolsCount(word)[1] == word.Length)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }

        static int[] GetUpperAndLowerSymbolsCount(string word)
        {
            int countLowerSymbols = 0;
            int countUpperSymbols = 0;

            foreach (char symbol in word)
            {
                if (symbol >= 97 && symbol <= 122)
                {
                    countLowerSymbols++;
                }
                else if (symbol >= 65 && symbol <= 90)
                {
                    countUpperSymbols++;
                }
            }

            int[] counter = { countLowerSymbols, countUpperSymbols };

            return counter;
        }
    }
}
