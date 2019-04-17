using System;
using System.Linq;
using System.Collections.Generic;

namespace P2AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> subsequences = Console.ReadLine().Split('|').ToList();

            subsequences.Reverse();

            foreach (string subsequence in subsequences)
            {
                string[] numbersOfSubsequence = subsequence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                Console.Write(string.Join(" ", numbersOfSubsequence) + " ");
            }
        }
    }
}
