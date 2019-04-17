using System;
using System.Collections.Generic;
using System.Linq;

namespace P6UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', '=', }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "end")
            {
                string IP = input[1];
                string userName = input[5];

                if (userLogs.ContainsKey(userName) == false)
                {
                    Dictionary<string, int> countIp = new Dictionary<string, int>();

                    countIp.Add(IP, 1);
                    userLogs.Add(userName, countIp);
                }
                else
                {
                    if (userLogs[userName].ContainsKey(IP) == false)
                    {
                        userLogs[userName].Add(IP, 1);
                    }
                    else
                    {
                        userLogs[userName][IP]++;
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '=', }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var currentUser in userLogs)
            { 
                List<string> userIpAddresses = new List<string>();
                
                Console.WriteLine($"{currentUser.Key}:");
                
                foreach (var ip in currentUser.Value)
                {
                    userIpAddresses.Add(string.Format("{0} => {1}", ip.Key, ip.Value));
                }
                
                Console.Write(string.Join(", ", userIpAddresses) + ".\n");
            }
        }
    }
}