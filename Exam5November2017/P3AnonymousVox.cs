using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P3AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)(.+)(\1)";

            string encodedText = Console.ReadLine();
            string[] placeholders = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            MatchCollection matches = Regex.Matches(encodedText, pattern);

            int count = 0;

            foreach (Match match in matches)
            {
                string decodedMessage = match.Groups[1] + placeholders[count] + match.Groups[3];
                count++;
                encodedText = encodedText.Replace(match.Value, decodedMessage);
            }

            Console.WriteLine(encodedText);
        }
    }
}
