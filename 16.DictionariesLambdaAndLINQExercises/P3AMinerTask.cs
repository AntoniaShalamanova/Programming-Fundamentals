using System;
using System.Linq;
using System.Collections.Generic;

namespace P3AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> mine = new Dictionary<string, double>();

            string metal = Console.ReadLine();
            int quantity = 0;

            while (metal != "stop")
            {
                quantity = int.Parse(Console.ReadLine());

                if (mine.ContainsKey(metal) == false)
                {
                    mine[metal] = 0;
                }
                mine[metal] += quantity;

                metal = Console.ReadLine();
            }

            foreach (var pair in mine)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
