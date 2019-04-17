using System;

namespace P12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;

            for (int num1 = firstNumber; num1 >= 1; num1--)
            {
                for (int num2 = 1; num2 <= secondNumber; num2++)
                {
                    sum += num1 * num2 * 3;
                    count++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
