using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int messagesCount = int.Parse(Console.ReadLine());
            string pattern = @"@(?<name>[A-Za-z]+).*:[^0-9]*(?<population>[0-9]+)[^!]*![^A|D]*(?<attak>[A|D])[^!]*!->[^0-9]*(?<count>[0-9]+)";

            for (int i = 0; i < messagesCount; i++)
            {
                string currentMessage = Console.ReadLine();

                int countStarLetters = CountStarLetters(currentMessage);

                currentMessage = ChangeMessage(currentMessage, countStarLetters);

                if (Regex.IsMatch(currentMessage, pattern))
                {
                    string attackType = Regex.Match(currentMessage, pattern).Groups["attak"].Value;
                    string planetName = Regex.Match(currentMessage, pattern).Groups["name"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
            destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count()}");
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count()}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static string ChangeMessage(string currentMessage, int countStarLetters)
        {
            string message = "";

            for (int i = 0; i < currentMessage.Length; i++)
            {
                message += (char)(currentMessage[i] - countStarLetters);
            }

            return message;
        }

        static int CountStarLetters(string currentMessage)
        {
            int symbolsCount = 0;
            currentMessage = currentMessage.ToLower();

            foreach (var symbol in currentMessage)
            {
                bool isCorrectLetter = (symbol == 's' || symbol == 't' || symbol == 'a' || symbol == 'r');

                if (isCorrectLetter)
                {
                    symbolsCount++;
                }
            }

            return symbolsCount;
        }
    }
}
