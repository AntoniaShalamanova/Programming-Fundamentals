using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P4MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<delimiter>.|-|\/)(?<month>[A-Z][a-z]{2})(\k<delimiter>)(?<year>\d{4})\b";
            string dates = Console.ReadLine();

            MatchCollection matchDates = Regex.Matches(dates, pattern);

            foreach (Match date in matchDates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
