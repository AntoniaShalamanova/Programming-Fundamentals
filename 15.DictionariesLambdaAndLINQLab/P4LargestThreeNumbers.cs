using System;
using System.Linq;
using System.Collections.Generic;

namespace P4LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            numbers = numbers.OrderByDescending(num => num).ToList();

            Console.WriteLine(string.Join(" ", numbers.Take(3)));
        }
    }
}
