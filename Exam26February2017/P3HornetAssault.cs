using System;
using System.Collections.Generic;
using System.Linq;

namespace P3HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> bees = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<int> hornets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            long hornetsSum = hornets.Sum();

            for (int i = 0; i < bees.Count; i++)
            {
                if (bees[i] >= hornetsSum)
                {
                    bees[i] -= hornetsSum;
                    hornetsSum -= hornets[0];
                    hornets.RemoveAt(0);

                    if (bees[i] == 0)
                    {
                        bees.RemoveAt(i);
                        i--;
                    }
                }
                else
                {
                    bees.RemoveAt(i);
                    i--;
                }
            }

            if (bees.Count != 0)
            {
                Console.WriteLine(string.Join(" ", bees));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
