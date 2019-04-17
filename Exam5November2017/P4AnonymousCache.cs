using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace P4AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            string command = Console.ReadLine();

            while (command != "thetinggoesskrra")
            {
                string[] input = command.Split(" |->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Length != 1)
                {
                    string dataKey = input[0];
                    long dataSize = long.Parse(input[1]);
                    string dataSet = input[2];

                    if (data.ContainsKey(dataSet) == false)
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }

                    data[dataSet][dataKey] = dataSize;
                }

                command = Console.ReadLine();
            }

            if (data.Count == 0)
            {
                return;
            }
            else
            {
                var highestDataSetSum = data.OrderByDescending(x => x.Value.Values.Sum()).First();
                string dataSet = highestDataSetSum.Key;
                long totalSize = highestDataSetSum.Value.Values.Sum();

                Console.WriteLine($"Data Set: {dataSet}, Total Size: {totalSize}");

                foreach (var dataSize in highestDataSetSum.Value.Keys)
                {
                    Console.WriteLine($"$.{dataSize}");
                }
            }
        }
    }
}
