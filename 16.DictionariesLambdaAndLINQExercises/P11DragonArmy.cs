using System;
using System.Collections.Generic;
using System.Linq;

namespace P11DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int dragonsNumber = int.Parse(Console.ReadLine());

            var dragonsArmy = new Dictionary<string, Dictionary<string, List<double>>>();

            string[] input = new string[5];
            string type = "";
            string name = "";
            double damage = 0;
            double health = 0;
            double armor = 0;

            for (int i = 0; i < dragonsNumber; i++)
            {
                input = Console.ReadLine().Split(' ').ToArray();

                type = input[0];
                name = input[1];

                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = double.Parse(input[2]);
                }

                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = double.Parse(input[3]);
                }

                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = double.Parse(input[4]);
                }

                if (dragonsArmy.ContainsKey(type) == false)
                {
                    List<double> statuses = new List<double>{ damage, health, armor };
                    Dictionary<string, List<double>> dragonsData = new Dictionary<string, List<double>>
                    {
                        { name, statuses}
                    };

                    dragonsArmy.Add(type, dragonsData);
                }
                else
                {
                    if (dragonsArmy[type].ContainsKey(name) == false)
                    {
                        List<double> statuses = new List<double> { damage, health, armor };

                        dragonsArmy[type].Add(name, statuses);
                    }
                    else
                    {
                        List<double> statuses = new List<double> { damage, health, armor };

                        dragonsArmy[type][name] = statuses;
                    }
                }
            }

            Console.ReadLine();
            foreach (var currentType in dragonsArmy)
            {
                double damageAverage = currentType.Value.Values.Average(x => x[0]);
                double healthAverage = currentType.Value.Values.Average(x => x[1]);
                double armorAverage = currentType.Value.Values.Average(x => x[2]);

                Console.WriteLine($"{currentType.Key}::({damageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");

                foreach (var currentDragon in currentType.Value.OrderBy(x => x.Key))
                {
                    damage = currentDragon.Value[0];
                    health = currentDragon.Value[1];
                    armor = currentDragon.Value[2];

                    Console.WriteLine($"-{currentDragon.Key} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}