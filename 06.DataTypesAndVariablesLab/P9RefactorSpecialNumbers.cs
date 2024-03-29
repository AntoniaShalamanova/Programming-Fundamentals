﻿using System;

namespace P9RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int sum = 0;
            int number = 0;
            bool isSpecial = false;

            for (int i = 1; i <= size; i++)
            {
                number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }

                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");

                sum = 0;
            }
        }
    }
}
