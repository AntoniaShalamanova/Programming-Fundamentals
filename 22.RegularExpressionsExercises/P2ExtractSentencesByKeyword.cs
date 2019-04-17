using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P2ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string particularword = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"\b{particularword}\b";

            string[] sentences = input.Split(new char[] { '.', '?', '!' }).ToArray();

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
