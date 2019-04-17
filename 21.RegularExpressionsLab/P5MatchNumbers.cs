using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P5MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))[-]?\d+(?:\.\d+)?($|(?=\s))";
            string numbers = Console.ReadLine();

            MatchCollection matchedNumbers = Regex.Matches(numbers, pattern);

            foreach (Match number in matchedNumbers)
            {
                Console.Write(number.Value + " ");
            }
        }
    }
}
