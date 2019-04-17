using System;
using System.Linq;

namespace P4DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point firstPoint = new Point();
            firstPoint.X = input[0];
            firstPoint.Y = input[1];

            input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point secondPoint = new Point();
            secondPoint.X = input[0];
            secondPoint.Y = input[1];

            Console.WriteLine($"{secondPoint.GetDistance(firstPoint):F3}");
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double GetDistance(Point firstPoint)
        {
            double xDistance = Math.Pow(X - firstPoint.X, 2);
            double yDistance = Math.Pow(Y - firstPoint.Y, 2);

            double distance = Math.Sqrt(xDistance + yDistance);

            return distance;
        }
    }
}
