using System;
using System.Text.RegularExpressions;

namespace P6ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string pattern = @"<a.*href.*?=(.*)>(.*?)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";

                string replaced = Regex.Replace(line, pattern, replacement);

                Console.WriteLine(replaced);

                line = Console.ReadLine();
            }
        }
    }
}
