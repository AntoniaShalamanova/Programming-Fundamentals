using System;
using System.Linq;
using System.Collections.Generic;

namespace P2PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneNumbers = new SortedDictionary<string, string>();

            string[] comands = Console.ReadLine().Split(' ').ToArray();

            while (comands[0] != "END")
            {
                if (comands[0] == "A")
                {
                    phoneNumbers[comands[1]] = comands[2];
                }
                else if (comands[0] == "S")
                {
                    if (phoneNumbers.ContainsKey(comands[1]) == false)
                    {
                        Console.WriteLine($"Contact {comands[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{comands[1]} -> {phoneNumbers[comands[1]]}");
                    }
                }
                else if (comands[0] == "ListAll")
                {
                    foreach (var pair in phoneNumbers)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }

                comands = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
