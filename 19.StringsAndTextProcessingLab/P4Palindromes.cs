using System;
using System.Collections.Generic;
using System.Linq;

namespace P4Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ' ', ',', '?', '!', '.'};
            string[] words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> palindromes = GetAllPalindromes(words);

            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", palindromes));
        }

        static List<string> GetAllPalindromes(string[] words)
        {
            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                if (word == string.Concat(word.Reverse()))
                {
                    palindromes.Add(word);
                }
            }

            return palindromes;
        }
    }
}
