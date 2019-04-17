using System;

namespace P4PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());

            int snapDay = int.Parse(Console.ReadLine());
            int snapMonth = int.Parse(Console.ReadLine());
            int snapYear = int.Parse(Console.ReadLine());

            int snapHours = int.Parse(Console.ReadLine());
            int snapMinutes = int.Parse(Console.ReadLine());

            double photoSize = int.Parse(Console.ReadLine());

            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {snapDay:D2}/{snapMonth:D2}/{snapYear:D4} {snapHours:D2}:{snapMinutes:D2}");

            int count = 0;
            while (photoSize.ToString().Length > 3)
            {
                count++;
                photoSize /= 1000.0;
            }

            string bytes = "";
            switch (count)
            {
                case 0:
                    bytes = "B";
                    break;

                case 1:
                    bytes = "KB";
                    break;

                case 2:
                    bytes = "MB";
                    break;

                case 3:
                    bytes = "GB";
                    break;

                case 4:
                    bytes = "TB";
                    break;
            }

            Console.WriteLine($"Size: {photoSize}{bytes}");

            string orientation = "";

            if (photoWidth == photoHeight)
            {
                orientation = "square";
            }
            else if (photoWidth < photoHeight)
            {
                orientation = "portrait";
            }
            else if (photoWidth > photoHeight)
            {
                orientation = "landscape";
            }
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({orientation})");
        }
    }
}
