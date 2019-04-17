using System;
using System.Linq;
using System.Collections.Generic;

namespace P9LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> keyMaterialsQuantity = new Dictionary<string, double>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };

            SortedDictionary<string, double> junkMaterialsQuantity = new SortedDictionary<string, double>();

            bool notObtained = true;

            while (notObtained)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                for (int i = 0; i <= input.Length - 2; i += 2)
                {
                    double quantity = double.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    switch (material)
                    {
                        case "shards":
                            {
                                keyMaterialsQuantity["shards"] += quantity;
                                break;
                            }
                        case "fragments":
                            {
                                keyMaterialsQuantity["fragments"] += quantity;
                                break;
                            }
                        case "motes":
                            {
                                keyMaterialsQuantity["motes"] += quantity;
                                break;
                            }
                        default:
                            {
                                if (junkMaterialsQuantity.ContainsKey(material) == false)
                                {
                                    junkMaterialsQuantity.Add(material, quantity);
                                }
                                else
                                {
                                    junkMaterialsQuantity[material] += quantity;
                                }

                                break;
                            }
                    }

                    if (keyMaterialsQuantity["shards"] >= 250)
                    {
                        notObtained = false;
                        break;
                    }
                    else if (keyMaterialsQuantity["fragments"] >= 250)
                    {
                        notObtained = false;
                        break;
                    }
                    else if (keyMaterialsQuantity["motes"] >= 250)
                    {
                        notObtained = false;
                        break;
                    }
                }
            }

            if (keyMaterialsQuantity["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                keyMaterialsQuantity["shards"] -= 250;
            }
            else if (keyMaterialsQuantity["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                keyMaterialsQuantity["fragments"] -= 250;
            }
            else if (keyMaterialsQuantity["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                keyMaterialsQuantity["motes"] -= 250;
            }

            foreach (var keyMaterial in keyMaterialsQuantity.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{keyMaterial.Key}: {keyMaterial.Value}");
            }

            foreach (var junk in junkMaterialsQuantity)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
