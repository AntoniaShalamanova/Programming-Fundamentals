using System;
using System.Linq;
using System.Numerics;

namespace P1SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            long stepsNumber = int.Parse(Console.ReadLine());
            long secondsPerStep = int.Parse(Console.ReadLine());

            long arrivalHours = time[0];
            long arrivalMinutes = time[1];
            long arrivalSeconds = time[2] + (stepsNumber * secondsPerStep);

            if (arrivalSeconds >= 60)
            {
                arrivalMinutes += (arrivalSeconds / 60);
                arrivalSeconds %= 60;
            }

            if (arrivalMinutes >= 60)
            {
                arrivalHours += (arrivalMinutes / 60);
                arrivalMinutes %= 60;
            }

            if (arrivalHours >= 24)
            {
                arrivalHours %= 24;
            }

            Console.WriteLine($"Time Arrival: {arrivalHours:D2}:{arrivalMinutes:D2}:{arrivalSeconds:D2}");
        }
    }
}
