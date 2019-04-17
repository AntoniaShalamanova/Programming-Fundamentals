using System;
using System.Linq;

namespace P2RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            Random randIndx = new Random();

            for (int currentIndx = 0; currentIndx < words.Length; currentIndx++)
            {
                string currentWord = words[currentIndx];
                int randWordIndx = randIndx.Next(0, words.Length);
                words[currentIndx] = words[randWordIndx];
                words[randWordIndx] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
