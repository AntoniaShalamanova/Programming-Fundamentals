using System;
using System.Linq;
using System.Collections.Generic;

namespace P6SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();

            numbers = numbers.Where(x => Math.Sqrt(x) % 1 == 0).ToList();

            numbers.Sort((a,b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
