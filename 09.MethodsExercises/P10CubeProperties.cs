using System;

namespace P10CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = GetLength(side, parameter);
            Console.WriteLine($"{result:F2}");
        }

        static double GetLength(double side, string parameter)
        {
            double result = 0;

            switch (parameter)
            {
                case "face":
                    result = side * Math.Sqrt(2);
                    break;

                case "space":
                    result = side * Math.Sqrt(3);
                    break;

                case "volume":
                    result = Math.Pow(side, 3);
                    break;

                case "area":
                    result = 6 * Math.Pow(side, 2);
                    break;
            }

            return result;
        }
    }
}
