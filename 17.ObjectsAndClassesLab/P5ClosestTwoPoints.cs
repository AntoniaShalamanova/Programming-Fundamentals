using System;
using System.Linq;
using System.Collections.Generic;

namespace P5ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();

            Point[] closestTwoPoints = FindClosestTwoPoints(points);

            Console.WriteLine($"{GetDistance(closestTwoPoints[0], closestTwoPoints[1]):F3}");
            Console.WriteLine($"({closestTwoPoints[0].X}, {closestTwoPoints[0].Y})");
            Console.WriteLine($"({closestTwoPoints[1].X}, {closestTwoPoints[1].Y})");
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = new Point[2];

            for (int currentPoint = 0; currentPoint < points.Length - 1; currentPoint++)
            {
                for (int nextPoint = currentPoint + 1; nextPoint < points.Length; nextPoint++)
                {
                    double currentDistance = GetDistance(points[currentPoint], points[nextPoint]);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        closestTwoPoints[0] = points[currentPoint];
                        closestTwoPoints[1] = points[nextPoint];
                    }
                }
            }

            return closestTwoPoints;
        }

        static double GetDistance(Point currentPoint, Point nextPoint)
        {
            double xDistance = Math.Pow(currentPoint.X - nextPoint.X, 2);
            double yDistance = Math.Pow(currentPoint.Y - nextPoint.Y, 2);

            double distance = Math.Sqrt(xDistance + yDistance);

            return distance;
        }

        static Point[] ReadPoints()
        {
            int pointsCount = int.Parse(Console.ReadLine());
            Point[] points = new Point[pointsCount];

            for (int i = 0; i < pointsCount; i++)
            {
                double[] coordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                Point point = new Point();
                point.X = coordinates[0];
                point.Y = coordinates[1];

                points[i] = point;
            }

            return points;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
