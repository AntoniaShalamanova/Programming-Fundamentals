using System;
using System.Collections.Generic;
using System.Linq;

namespace P1CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (numbersCount.ContainsKey(number) == false)
                {
                    numbersCount[number] = 0;
                }
            
                numbersCount[number]++;
            }

            foreach (KeyValuePair<double, int> pair in numbersCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
