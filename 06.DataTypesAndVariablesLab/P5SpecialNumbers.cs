using System;

namespace P5SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                bool isSpecial;
                int currentNum = i;

                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                else
                {
                    isSpecial = false;
                }

                Console.WriteLine($"{i} -> {isSpecial}");

                sum = 0;
            }
        }
    }
}
