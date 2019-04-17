using System;

namespace P8RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heigt = double.Parse(Console.ReadLine());
            double volume = (length * width * heigt) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
