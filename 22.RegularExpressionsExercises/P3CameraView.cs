using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P3CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int elementsToSkip = numbers[0];
            int elementsToTake = numbers[1];

            string input = Console.ReadLine();

            string pattern = @"\|<([\w]{" + elementsToSkip + @"})([\w]{0," + elementsToTake +"})";

            MatchCollection founds = Regex.Matches(input, pattern);

            List<string> result = new List<string>();

            foreach (Match view in founds)
            {
                result.Add(view.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
