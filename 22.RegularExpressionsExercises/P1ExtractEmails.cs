using System;
using System.Text.RegularExpressions;

namespace P1ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))([a-z0-9]+)([_\.-]?[a-z0-9])*@([a-z0-9])+([-.][a-z0-9]+)*\.([a-z0-9]+)([-.][a-z0-9]+)*";

            MatchCollection matchEmails = Regex.Matches(input, pattern);

            foreach (Match email in matchEmails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
