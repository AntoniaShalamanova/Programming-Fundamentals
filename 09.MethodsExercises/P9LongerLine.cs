using System;

namespace P9LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            Console.WriteLine(GetCoordinateOfClosestPoint(x1, y1, x2, y2, x3, y3, x4, y4));
        }

        static string GetCoordinateOfClosestPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            string result = "";
            double firstPointDistance = 0;
            double secondPointDistance = 0;

            double firstPairDistance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double secondPairDistance = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));

            if (firstPairDistance >= secondPairDistance)
            {
                firstPointDistance = Math.Sqrt(x1 * x1 + y1 * y1);
                secondPointDistance = Math.Sqrt(x2 * x2 + y2 * y2);

                if (firstPointDistance <= secondPointDistance)
                {
                    result = string.Format($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    result = string.Format($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                firstPointDistance = Math.Sqrt(x3 * x3 + y3 * y3);
                secondPointDistance = Math.Sqrt(x4 * x4 + y4 * y4);

                if (firstPointDistance <= secondPointDistance)
                {
                    result = string.Format($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    result = string.Format($"({x4}, {y4})({x3}, {y3})");
                }
            }

            return result;
        }
    }
}
