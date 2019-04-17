using System;
using System.Linq;

namespace P8MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentCount = 0;
            int mostFrequentNumber = 0;
            int mostFrequentCount = 0;


            for (int compareNumber = 0; compareNumber < numbers.Length; compareNumber++)
            {
                for (int currentNumber = 0; currentNumber < numbers.Length; currentNumber++)
                {
                    if (numbers[compareNumber] == numbers[currentNumber])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > mostFrequentCount)
                {
                    mostFrequentCount = currentCount;
                    mostFrequentNumber = numbers[compareNumber];
                }

                currentCount = 0;
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}
