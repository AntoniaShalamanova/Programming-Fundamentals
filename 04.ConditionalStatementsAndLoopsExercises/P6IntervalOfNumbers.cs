using System;

namespace P06IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int firstNum = Math.Min(num1, num2);
            int lastNum = Math.Max(num1, num2);

            for (int i = firstNum; i <= lastNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
