using System;
using System.Linq;
using System.Collections.Generic;

namespace P5ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            words = words
                   .Where(word => word.Length < 5)
                   .Select(word => word.ToLower())
                   .Distinct()
                   .OrderBy(word => word)
                   .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
