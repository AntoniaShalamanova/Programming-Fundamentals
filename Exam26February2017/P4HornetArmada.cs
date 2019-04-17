using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Dictionary<string, Army> legionsData = new Dictionary<string, Army>();

            for (int i = 0; i < inputNumber; i++)
            {
                Army currentSoldier = new Army();

                string[] data = Console.ReadLine().Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                int lastActivity = int.Parse(data[0]);
                string legionName = data[1]; 
                string soldierType = data[2];
                long soldierCount = long.Parse(data[3]);
                
                bool isAdded = false;
                if (legionsData.ContainsKey(legionName))
                {
                    foreach (Soldier soldier in legionsData[legionName].Soldiers)
                    {
                        if (soldier.SoldierType == soldierType)
                        {
                            isAdded = true;
                            soldier.SoldierCount += soldierCount;
                        }
                    }
                    if (!isAdded)
                    {
                        Soldier newSoldier = new Soldier();
                        newSoldier.SoldierType = soldierType;
                        newSoldier.SoldierCount = soldierCount;
                        legionsData[legionName].Soldiers.Add(newSoldier);
                    }

                    if (lastActivity > legionsData[legionName].LastActivity)
                    {
                        legionsData[legionName].LastActivity = lastActivity;
                    }
                } 
                else
                {
                    currentSoldier.LastActivity = lastActivity;
                    Soldier newSoldier = new Soldier();
                    newSoldier.SoldierCount = soldierCount;
                    newSoldier.SoldierType = soldierType;
                    currentSoldier.Soldiers.Add(newSoldier);
                    
                    legionsData.Add(legionName, currentSoldier);
                }
                
            }

            string[] command = Console.ReadLine().Split('\\').ToArray();

            if (command.Length == 2)
            {
                int activity = int.Parse(command[0]);
                string soldierType = command[1];

                //In the first case, you must print all legions, and the count of soldiers 
                //they have from the given soldier type, who’s last activity is LOWER than the given activity.
                //The legions must be printed in descending order by soldier count.

                foreach (Army armyData in legionsData.Values)
                {
                    armyData.Soldiers.RemoveAll(x => x.SoldierType != soldierType);
                }

                Dictionary<string, long> results = new Dictionary<string, long>();
                foreach (var armyData in legionsData)
                {
                    foreach (var soldier in armyData.Value.Soldiers.OrderByDescending(x => x.SoldierCount))
                    {
                        if (armyData.Value.LastActivity < activity)      
                            results.Add(armyData.Key, soldier.SoldierCount);
                    }
                    
                }

                foreach (var result in results.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{result.Key} -> {result.Value}");
                }
               
            }
            else if (command.Length == 1)
            {
                string soldierType = command[0];

                //In the second case, you must print all legions which have the given soldier type, with last activity, and legion name.
                //The legions must be printed in descending order of their activity.

                legionsData = legionsData.OrderByDescending(x => x.Value.LastActivity).ToDictionary(x => x.Key, x => x.Value);

                foreach (Army armyData in legionsData.Values)
                {
                    armyData.Soldiers.RemoveAll(x => x.SoldierType != soldierType);
                }
 
                foreach (var legionData in legionsData)
                {
                    Console.WriteLine($"{legionData.Value.LastActivity} : {legionData.Key}");
                }
            }
        }
    }

    class Soldier
    {
        public string SoldierType { get; set; }
        public long SoldierCount { get; set; }
    }

    class Army
    {
        public int LastActivity { get; set; }
        public List<Soldier> Soldiers = new List<Soldier>();
    }
}
