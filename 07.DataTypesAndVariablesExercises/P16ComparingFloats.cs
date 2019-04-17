using System;

namespace P16ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double bigNum = Math.Max(num1, num2);
            double smallNum = Math.Min(num1, num2);

            double diff = bigNum - smallNum;

            if (diff < 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
