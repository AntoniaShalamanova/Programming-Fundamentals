using System;
using System.Linq;
using System.Collections.Generic;

namespace P4FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailBook = new Dictionary<string, string>();

            string name = Console.ReadLine();
            string mail = "";

            while (name != "stop")
            {
                mail = Console.ReadLine();

                if (mailBook.ContainsKey(name) == false)
                {
                    mailBook[name] = "";
                }

                mailBook[name] = mail;

                name = Console.ReadLine();
            }

            foreach (var pair in mailBook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
