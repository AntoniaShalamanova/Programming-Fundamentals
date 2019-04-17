using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P6ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiter = new char[] { ' ', '/', '\\', '(', ')' };
            string[] usernames = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"^([A-Za-z]+([_]?[A-Za-z\d]+)*){3,25}";

            List<string> matchedUsernames = new List<string>();

            foreach (string username in usernames)
            {
                if (Regex.IsMatch(username, pattern))
                {
                    matchedUsernames.Add(username);
                }
            }

            int maxSumLength = 0;
            string currentUsername = "";
            string nextUsername = "";

            for (int i = 0; i < matchedUsernames.Count - 1; i++)
            {
                int currentUsernameLength = matchedUsernames[i].Length;
                int nextUsernameLength = matchedUsernames[i+1].Length;

                if (currentUsernameLength + nextUsernameLength > maxSumLength)
                {
                    currentUsername = matchedUsernames[i];
                    nextUsername = matchedUsernames[i+1];
                    maxSumLength = currentUsernameLength + nextUsernameLength;
                }
            }

            Console.WriteLine(currentUsername);
            Console.WriteLine(nextUsername);
        }
    }
}
