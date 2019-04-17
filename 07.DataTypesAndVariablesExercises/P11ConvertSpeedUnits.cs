using System;

namespace P11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = seconds + minutes * 60 + hours * 3600;
            float metersPerSecond = (float)meters / totalSeconds;
            float kilometersPerHour = ((float)meters / 1000) / ((float)totalSeconds / 3600);
            float milesPerHour= ((float)meters / 1609) / ((float)totalSeconds / 3600);

            Console.WriteLine($"{metersPerSecond:0.######}");
            Console.WriteLine($"{kilometersPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");
        }
    }
}
