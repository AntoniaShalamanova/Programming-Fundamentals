using System;
using System.Collections.Generic;
using System.Linq;

namespace P4Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<KeyValuePair<string, string>, int> dwarfs = new Dictionary<KeyValuePair<string, string>, int>();
            Dictionary<string, int> colors = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                String[] dwarfData = input.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string dwarfName = dwarfData[0];
                string dwarfHatColor = dwarfData[1];
                int dwarfPhysics = int.Parse(dwarfData[2]);

                KeyValuePair<string, string> dwarfID = new KeyValuePair<string, string>(dwarfName, dwarfHatColor);

                if (dwarfs.ContainsKey(dwarfID) == false)
                {
                    if (colors.ContainsKey(dwarfHatColor) == false)
                    {
                        colors.Add(dwarfHatColor, 0);
                    }

                    colors[dwarfHatColor]++;

                    dwarfs.Add(dwarfID, dwarfPhysics);
                }
                else
                {
                    if (dwarfs[dwarfID] < dwarfPhysics)
                    {
                        dwarfs[dwarfID] = dwarfPhysics;
                    }
                }

                input = Console.ReadLine();
            }


            dwarfs = dwarfs
                 .OrderByDescending(x => x.Value)
                 .ThenByDescending(x => colors[x.Key.Value])
                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var dwarf in dwarfs)
            {
                string name = dwarf.Key.Key;
                string hatColor = dwarf.Key.Value;
                int physics = dwarf.Value;

                Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            }
        }
    }
}
