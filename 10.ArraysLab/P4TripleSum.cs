using System;
using System.Linq;

namespace P4TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write(GetSums(numbers));
        }

        static string GetSums(int[] numbers)
        {
            string result = "";
            bool hasMatch = false;
            for (int currentNumber = 0; currentNumber < numbers.Length; currentNumber++)
            {
                for (int nextNumber = currentNumber + 1; nextNumber < numbers.Length; nextNumber++)
                {
                    int sum = numbers[currentNumber] + numbers[nextNumber];
                    if (numbers.Contains(sum))
                    {
                        result += ($"{numbers[currentNumber]} + {numbers[nextNumber]} == {sum}\r\n");
                        hasMatch = true;
                    }
                }
            }

            if (!hasMatch)
            {
                result = "No";
            }

            return result;
        }
    }
}
