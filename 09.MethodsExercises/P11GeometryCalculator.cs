using System;

namespace P11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureTipe = Console.ReadLine();

            double area = GetArea(figureTipe);
            Console.WriteLine($"{area:F2}");
        }

        static double GetArea(string figureType)
        {
            double area = 0;

            switch (figureType)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    area = (triangleSide * triangleHeight) / 2;
                    break;

                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    area = Math.Pow(squareSide, 2);
                    break;

                case "rectangle":
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    area = rectangleHeight * rectangleWidth;
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                    break;
            }

            return area;
        }
    }
}
