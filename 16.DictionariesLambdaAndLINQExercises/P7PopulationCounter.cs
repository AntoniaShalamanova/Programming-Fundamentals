using System;
using System.Collections.Generic;
using System.Linq;

namespace P7PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populationCounter = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split('|').ToArray();

            while (input[0] != "report")
            {
                string sityName = input[0];
                string countryName = input[1];
                long population = long.Parse(input[2]);

                if (populationCounter.ContainsKey(countryName) == false)
                {
                    Dictionary<string, long> townPopulation = new Dictionary<string, long>();

                    townPopulation.Add(sityName, population);
                    populationCounter.Add(countryName, townPopulation);
                }
                else
                {
                    populationCounter[countryName].Add(sityName, population);
                }

                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var currentCountry in populationCounter.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{currentCountry.Key} (total population: {currentCountry.Value.Values.Sum()})");

                foreach (var currentCity in currentCountry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{currentCity.Key}: {currentCity.Value}");
                }
            }
        }
    }
}
