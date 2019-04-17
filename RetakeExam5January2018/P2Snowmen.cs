using System;
using System.Collections.Generic;
using System.Linq;

namespace P2Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmens = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            HashSet<int> losers = new HashSet<int>();

            while (snowmens.Count > 1)
            {
                for (int attacker = 0; attacker < snowmens.Count; attacker++)
                {
                    int target = snowmens[attacker] % snowmens.Count;

                    if (snowmens.Count - losers.Count == 1)
                    {
                        break;
                    }

                    if (losers.Contains(attacker))
                    {
                        continue;
                    }

                    int absoluteDiff = Math.Abs(attacker - target);

                    if (attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        losers.Add(attacker);
                        snowmens[attacker] = -1;
                    }
                    else if (absoluteDiff % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        losers.Add(target);
                        snowmens[target] = -1;
                    }
                    else if (absoluteDiff % 2 != 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        losers.Add(attacker);
                        snowmens[attacker] = -1;
                    }
                }

                snowmens.RemoveAll(x => x == -1);
                losers.Clear();
            }
        }
    }
}
