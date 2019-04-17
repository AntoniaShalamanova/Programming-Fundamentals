using System;
using System.Linq;

namespace P4CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string firstWord = input[0];
            string secondWord = input[1];
            int sum = 0;

            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            for (int j = Math.Min(firstWord.Length, secondWord.Length); j < Math.Max(firstWord.Length, secondWord.Length); j++)
            {
                try
                {
                    sum += firstWord[j];
                }
                catch
                {

                    sum += secondWord[j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
