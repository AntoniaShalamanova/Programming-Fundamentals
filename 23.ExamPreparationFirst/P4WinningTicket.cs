using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P4WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = @"([\^]{6,10}|[$]{6,10}|[#]{6,10}|[@]{6,10})([\w]+)?(\1)([\w]+|$)";

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                }
                else
                {
                    if (Regex.IsMatch(tickets[i], pattern))
                    {
                        string match = Regex.Match(tickets[i], pattern).Groups[1].Value;
                        if (match.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {match.Length}{match[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {match.Length}{match[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
            }
        }
    }
}
