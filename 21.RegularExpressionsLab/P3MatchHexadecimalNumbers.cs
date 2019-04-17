using System;
using System.Text.RegularExpressions;

namespace P3MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            string hexNumbers = Console.ReadLine();
            
            MatchCollection matchedHexNumbers = Regex.Matches(hexNumbers, pattern);

            foreach (Match hexNum in matchedHexNumbers)
            {
                Console.Write(hexNum.Value + " ");
            }
        }
    }
}
