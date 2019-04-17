using System;

namespace P1HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int flapsToMake = int.Parse(Console.ReadLine());
            double mPerThousandFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double totalMeters = (flapsToMake / 1000.0) * mPerThousandFlaps;
            int totalSeconds = (flapsToMake / 100) + (flapsToMake / endurance) * 5;

            Console.WriteLine($"{totalMeters:F2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
