using System;
using System.Linq;
using System.Collections.Generic;

namespace P5MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string firstWord = input[0].ToLower();
            string secondWord = input[1].ToLower();

            if (areExchangeable(firstWord, secondWord))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static bool areExchangeable(string firstWord, string secondWord)
        {
            bool areExchangeable = true;
            Dictionary<char, char> pairsOfSymbols = new Dictionary<char, char>();
            int wordsMaxLength = Math.Max(firstWord.Length, secondWord.Length);
            int wordsMinLength = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < wordsMinLength; i++)
            {
                char firstWordSymbol = firstWord[i];
                char secondWordSymbol = secondWord[i];

                if (pairsOfSymbols.ContainsKey(firstWordSymbol) == false)
                {
                    pairsOfSymbols.Add(firstWordSymbol, secondWordSymbol);
                }
                else
                {
                    if (pairsOfSymbols[firstWordSymbol] != secondWordSymbol)
                    {
                        return false;
                    }
                }
            }

            for (int i = wordsMinLength; i < wordsMaxLength; i++)
            {
                char currentSymbol;

                try
                {
                    currentSymbol = firstWord[i];

                    if (pairsOfSymbols.ContainsKey(currentSymbol) == false)
                    {
                        return false;
                    }
                }
                catch
                {
                    currentSymbol = secondWord[i];

                    if (pairsOfSymbols.ContainsValue(currentSymbol) == false)
                    {
                        return false;
                    }
                }


            }

            return areExchangeable;
        }
    }
}
