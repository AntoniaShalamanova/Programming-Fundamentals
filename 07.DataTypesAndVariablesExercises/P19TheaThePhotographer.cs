using System;

namespace P19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long picturesNumber = int.Parse(Console.ReadLine());
            long filterTime = int.Parse(Console.ReadLine());
            long percentGoodPictures = int.Parse(Console.ReadLine());
            long uploadTime = int.Parse(Console.ReadLine());

            double filteredPictures = picturesNumber * (percentGoodPictures / 100.0);
            double filteredPicturesCeil = Math.Ceiling(filteredPictures);
            long totalTime = (picturesNumber * filterTime) + ((int)filteredPicturesCeil * uploadTime);

            long days = totalTime / 86400;
            totalTime %= 86400;
            long hours = totalTime / 3600;
            totalTime %= 3600;
            long minutes = totalTime / 60;
            totalTime %= 60;
            long seconds = totalTime;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
