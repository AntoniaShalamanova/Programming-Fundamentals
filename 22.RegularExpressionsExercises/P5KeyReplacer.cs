using System;
using System.Text.RegularExpressions;

namespace P5KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyStr = Console.ReadLine();
            string text = Console.ReadLine();

            string keyPattern = @"^([A-Za-z]+)(.+[<|\\])([A-Za-z]+)";

            string startKey = Regex.Match(keyStr, keyPattern).Groups[1].ToString();
            string endKey = Regex.Match(keyStr, keyPattern).Groups[3].ToString();

            string textPattern = $@"({startKey})(.*?)({endKey})";

            MatchCollection matchedWords = Regex.Matches(text, textPattern);

            string result = "";
            foreach (Match match in matchedWords)
            {
                result += Regex.Match(match.ToString(), textPattern).Groups[2].ToString();
            }

            if (result == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
