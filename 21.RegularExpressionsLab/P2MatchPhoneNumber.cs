using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P2MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(?<delimiter> |-)2\k<delimiter>[0-9]{3}\k<delimiter>[0-9]{4}\b";

            string phoneNumbers = Console.ReadLine();
            
            MatchCollection matchedNumbers = Regex.Matches(phoneNumbers, pattern);

            Console.WriteLine(string.Join(", ", matchedNumbers.Cast<Match>().Select(a => a.Value).ToArray()));
        }
    }
}
