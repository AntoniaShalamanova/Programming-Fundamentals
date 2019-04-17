using System;

namespace P5BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int totalBeats = int.Parse(Console.ReadLine());

            double bars = totalBeats / 4.0;
            int minutes = 0;
            int seconds = 0;

            double beatsPerSecond = beatsPerMinute / 60.0;
            int totalSeconds = (int)(totalBeats / beatsPerSecond);
            
            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;

            Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");
        }
    }
}
