using System;
using System.Collections.Generic;
using System.Linq;

namespace P2OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string currentWord = word.ToLower();
                if (wordsCount.ContainsKey(currentWord) == false)
                {
                    wordsCount[currentWord] = 0;
                }

                wordsCount[currentWord]++;
            }

            List<string> result = new List<string>();

            foreach (var pair in wordsCount.Where(str => str.Value % 2 != 0))
            {
                result.Add(pair.Key);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

