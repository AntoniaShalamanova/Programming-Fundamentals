using System;

namespace P5WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                noun += "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("z") || 
                     noun.EndsWith("s") || noun.EndsWith("x") || 
                     noun.EndsWith("ch") || noun.EndsWith("sh"))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }

            Console.WriteLine(noun);
        }
    }
}
