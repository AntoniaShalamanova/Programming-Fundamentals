using System;

namespace P3Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double MP = (width * height) / 1000000.0;
            Console.WriteLine($"{width}x{height} => {Math.Round(MP, 1)}MP");
        }
    }
}
