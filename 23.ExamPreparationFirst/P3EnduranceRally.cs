using System;
using System.Linq;

namespace P3EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] driversNames = Console.ReadLine().Split(' ').ToArray();
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int racer = 0; racer < driversNames.Length; racer++)
            {
                string name = driversNames[racer];
                double fuel = name[0];
                int reachedZone = 0;

                for (int zone = 0; zone < zones.Length; zone++)
                {
                    if (checkpoints.Contains(zone))
                    {
                        fuel += zones[zone];
                    }
                    else
                    {
                        fuel -= zones[zone];
                    }

                    if (fuel <= 0)
                    {
                        reachedZone = zone;
                        break;
                    }
                }

                if (fuel <= 0)
                {
                    Console.WriteLine($"{name} - reached {reachedZone}");
                }
                else
                {
                    Console.WriteLine($"{name} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
