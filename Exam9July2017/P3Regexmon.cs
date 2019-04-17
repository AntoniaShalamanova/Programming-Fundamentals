using System;
using System.Text.RegularExpressions;

namespace P3Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string bojomonPattern = @"([A-Za-z]+[-][A-Za-z]+)";
            string didimonPattern = @"([^A-Za-z-]+)";
            int roundCount = 1;

            while (true)
            {
                string pattern = "";

                if (roundCount % 2 != 0)
                {
                    pattern = didimonPattern;
                }
                else
                {
                    pattern = bojomonPattern;
                }

                if (Regex.IsMatch(text, pattern))
                {
                    string currentMatch = Regex.Match(text, pattern).ToString();
                    roundCount++;
                    Console.WriteLine(currentMatch);

                    text = text.Substring(text.IndexOf(currentMatch) + currentMatch.Length);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
