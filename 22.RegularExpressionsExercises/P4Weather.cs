using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P4Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})([\d]+\.[\d]+)([A-Za-z]+\|)";
            Regex regex = new Regex(pattern);
            Dictionary<string, List <string>> citiesWeather = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                Match match = regex.Match(input);

                if (match.ToString() != "")
                {
                    string townName = match.Groups[1].Value.ToString();
                    string temperature = match.Groups[2].Value.ToString();
                    string weather = match.Groups[3].Value.ToString();

                    List<string> data = new List<string> { temperature, weather.Remove(weather.Length - 1, 1) };

                    if (citiesWeather.ContainsKey(townName) == false)
                    {
                        citiesWeather.Add(townName, data);
                    }
                    else
                    {
                        citiesWeather[townName] = data;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var town in citiesWeather.OrderBy(x => double.Parse(x.Value[0])))
            {
                Console.WriteLine($"{town.Key} => {double.Parse(town.Value[0]):F2} => {town.Value[1]}");
            }
        }
    }
}
