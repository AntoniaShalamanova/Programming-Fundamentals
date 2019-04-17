using System;
using System.Linq;
using System.Collections.Generic;

namespace P6SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            foreach (int numb in numbers)
            {
                List<char> number = numb.ToString().ToList();
                number.Reverse();

                sum += int.Parse(string.Join("", number));
            }

            Console.WriteLine(sum);
        }
    }
}
