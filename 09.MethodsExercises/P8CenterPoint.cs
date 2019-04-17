using System;

namespace P8CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(GetCoordinateOfClosestPoint(x1, y1, x2, y2));
        }

        static string GetCoordinateOfClosestPoint(double x1, double y1, double x2, double y2)
        {
            string result = "";

            double firstPointDistance = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondPointDistance = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstPointDistance <= secondPointDistance)
            {
                result = string.Format($"({x1}, {y1})");
            }
            else
            {
                result = string.Format($"({x2}, {y2})");
            }

            return result;
        }
    }
}
