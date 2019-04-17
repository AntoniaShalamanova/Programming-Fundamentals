using System;
using System.Collections.Generic;
using System.Linq;

namespace P2SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> performersAwards = new Dictionary<string, List<string>>();

            string[] singers = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            string[] songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

            string data = Console.ReadLine();

            while (data != "dawn")
            {
                string[] performance = data.Split(',').Select(x => x.Trim()).ToArray();

                string singerName = performance[0];
                string songName = performance[1];
                string award = performance[2];

                if (singers.Contains(singerName) && songs.Contains(songName))
                {
                    if (performersAwards.ContainsKey(singerName) == false)
                    {
                        List<string> awards = new List<string> { award };

                        performersAwards.Add(singerName, awards);
                    }
                    else
                    {
                        if (performersAwards[singerName].Contains(award) == false)
                        {
                            performersAwards[singerName].Add(award);
                        }
                    }
                }

                data = Console.ReadLine();
            }

            if (performersAwards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            performersAwards = performersAwards
                .OrderByDescending(x => x.Value.Count())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var singer in performersAwards)
            {
                Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");

                foreach (var award in singer.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
