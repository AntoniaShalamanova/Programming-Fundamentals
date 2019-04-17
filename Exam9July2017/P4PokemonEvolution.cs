using System;
using System.Collections.Generic;
using System.Linq;

namespace P4PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Evolution>> pokemons = new Dictionary<string, List<Evolution>>();
            string input = Console.ReadLine();

            while (input != "wubbalubbadubdub")
            {
                string[] pokemonData = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string pokemonName = pokemonData[0];

                if (pokemonData.Length == 1)
                {
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var evolution in pokemons[pokemonName])
                        {
                            Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                        }
                    }
                }
                else
                {
                    Evolution evolution = new Evolution();
                    evolution.EvolutionType = pokemonData[1];
                    evolution.EvolutionIndex = int.Parse(pokemonData[2]);

                    if (pokemons.ContainsKey(pokemonName) == false)
                    {
                        List<Evolution> evolutionList = new List<Evolution> { evolution };

                        pokemons.Add(pokemonName, evolutionList);
                    }
                    else
                    {
                        pokemons[pokemonName].Add(evolution);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var evolution in pokemon.Value.OrderByDescending(x => x.EvolutionIndex))
                {
                    Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                }
            }
        }
    }

    class Evolution
    {
        public string EvolutionType { get; set; }
        public int EvolutionIndex { get; set; }
    }
}
