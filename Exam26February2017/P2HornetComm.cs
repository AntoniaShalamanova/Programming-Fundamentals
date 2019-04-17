using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace P2HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<StringBuilder, List<string>> broadcasts = new Dictionary<StringBuilder, List<string>>();
            Dictionary<string, List<string>> privateMessages = new Dictionary<string, List<string>>();
            string broadcastPattern = @"^([^0-9]+)( <-> )([A-Za-z]*[0-9]*([A-Za-z]*[0-9]*)*)$";
            string messagePattern = @"^([0-9]+)( <-> )([0-9]*[A-Za-z]*([0-9]*[A-Za-z]*)*)$";

            string data = Console.ReadLine();

            while (data != "Hornet is Green")
            {
                if (Regex.IsMatch(data, broadcastPattern))
                {
                    string message = Regex.Match(data, broadcastPattern).Groups[1].Value;
                    StringBuilder frequency = new StringBuilder();
                    frequency.Append(Regex.Match(data, broadcastPattern).Groups[3].Value);

                    frequency = ChangeLetters(frequency);

                    if (broadcasts.ContainsKey(frequency) == false)
                    {
                        broadcasts.Add(frequency, new List<string>());
                    }

                    broadcasts[frequency].Add(message);
                }
                else if (Regex.IsMatch(data, messagePattern))
                {
                    string code = Regex.Match(data, messagePattern).Groups[1].Value;
                    string message = Regex.Match(data, messagePattern).Groups[3].Value;

                    code = string.Join("", code.Reverse());

                    if (privateMessages.ContainsKey(code) == false)
                    {
                        privateMessages.Add(code, new List<string>());
                    }

                    privateMessages[code].Add(message);
                }

                data = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var frequency in broadcasts)
                {
                    foreach (var message in frequency.Value)
                    {
                        Console.WriteLine($"{frequency.Key} -> {message}");
                    }
                }
            }

            Console.WriteLine("Messages:");
            if (privateMessages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var code in privateMessages)
                {
                    foreach (var message in code.Value)
                    {
                        Console.WriteLine($"{code.Key} -> {message}");
                    }
                }
            }
        }

        static StringBuilder ChangeLetters(StringBuilder frequency)
        {
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] >= 'A' && frequency[i] <= 'Z')
                {
                    frequency[i] = char.Parse(frequency[i].ToString().ToLower());
                }
                else if (frequency[i] >= 'a' && frequency[i] <= 'z')
                {
                    frequency[i] = char.Parse(frequency[i].ToString().ToUpper());
                }
            }

            return frequency;
        }
    }
}
