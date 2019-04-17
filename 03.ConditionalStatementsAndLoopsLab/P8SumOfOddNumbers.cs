using System;

namespace P8SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int numb = 1;

            while (true)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine(numb);
                    sum += numb;
                    numb += 2;
                }
                break;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
