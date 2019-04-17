using System;
using System.Text.RegularExpressions;

namespace P3Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surface1 = Console.ReadLine();
            string mantle1 = Console.ReadLine();
            string wholeSnowflake = Console.ReadLine();
            string mantle2 = Console.ReadLine();
            string surface2 = Console.ReadLine();

            string startStr = "^";
            string endStr = "$";

            string surfacePattern = @"([\W_]+)";
            string mantlePattern = @"([\d_]+)";
            string corePattern = "(?<core>[A-Za-z]+)";

            string wholeSnowflakePattern = startStr + surfacePattern + mantlePattern + corePattern + mantlePattern + surfacePattern + endStr;
            surfacePattern = startStr + surfacePattern + endStr;
            mantlePattern = startStr + mantlePattern + endStr;

            if ((Regex.IsMatch(surface1, surfacePattern))
                && (Regex.IsMatch(mantle1, mantlePattern))
                && (Regex.IsMatch(wholeSnowflake, wholeSnowflakePattern))
                && (Regex.IsMatch(mantle2, mantlePattern))
                && (Regex.IsMatch(surface2, surfacePattern)))
            {
                Console.WriteLine("Valid");
                Console.WriteLine(Regex.Match(wholeSnowflake, wholeSnowflakePattern).Groups["core"].Value.Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }

}
