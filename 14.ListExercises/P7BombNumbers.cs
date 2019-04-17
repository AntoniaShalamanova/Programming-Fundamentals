using System;
using System.Linq;
using System.Collections.Generic;

namespace P7BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombNumbAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bombNumber = bombNumbAndPower[0];
            int power = bombNumbAndPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int begin = i - power;
                    if (begin < 0)
                    {
                        begin = 0;
                    }

                    int end = i + power;
                    if (end > numbers.Count - 1)
                    {
                        end = numbers.Count - 1;
                    }

                    numbers.RemoveRange(begin, end - begin + 1);
                    i = 0;
                }
            }

            int sum = 0;

            foreach (int numb in numbers)
            {
                sum += numb;
            }

            Console.WriteLine(sum);
        }
    }
}
