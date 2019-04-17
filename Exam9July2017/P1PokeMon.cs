using System;

namespace P1PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int decrPokePower = pokePower;
            int targetsCount = 0;

            while (decrPokePower >= distance)
            {
                decrPokePower -= distance;
                targetsCount++;

                if (decrPokePower == pokePower / 2 && pokePower % 2 == 0 && exhaustionFactor != 0)
                {
                    decrPokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(decrPokePower);
            Console.WriteLine(targetsCount);
        }
    }
}
