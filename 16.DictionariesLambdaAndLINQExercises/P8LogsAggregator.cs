using System;
using System.Collections.Generic;
using System.Linq;

namespace P8LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int logLinesCount = int.Parse(Console.ReadLine());

            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string[] logLine = new string[logLinesCount];

            for (int i = 0; i < logLinesCount; i++)
            {
                logLine = Console.ReadLine().Split(' ').ToArray();

                string ip = logLine[0];
                string userName = logLine[1];
                int duration = int.Parse(logLine[2]);

                if (userLogs.ContainsKey(userName) == false)
                {
                    Dictionary<string, int> ipAndDuration = new Dictionary<string, int>();

                    ipAndDuration.Add(ip, duration);

                    userLogs.Add(userName, ipAndDuration);
                }
                else
                {
                    if (userLogs[userName].ContainsKey(ip) == false)
                    {
                        userLogs[userName].Add(ip, duration);
                    }
                    else
                    {
                        userLogs[userName][ip] += duration;
                    }
                }
            }

            foreach (var currentUser in userLogs)
            {
                Console.Write($"{currentUser.Key}: {currentUser.Value.Values.Sum()} ");

                List<string> ipAdresses = new List<string>();

                foreach (var ipAdress in currentUser.Value.Keys.OrderBy(x => x))
                {
                    ipAdresses.Add(ipAdress);
                }

                Console.WriteLine("[" + string.Join(", ",ipAdresses) + "]");
            }
        }
    }
}
