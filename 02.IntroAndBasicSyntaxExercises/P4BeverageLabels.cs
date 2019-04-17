using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double ml = volume / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{ml * energy}kcal, {ml * sugar}g sugars");
        }
    }
}
