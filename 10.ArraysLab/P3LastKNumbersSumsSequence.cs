using System;

namespace P3LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long size = long.Parse(Console.ReadLine());
            int numbsCount = int.Parse(Console.ReadLine());


            long[] numbers = GetNumbers(size, numbsCount);
            foreach (long num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        static long[] GetNumbers(long size, long numbsCount)
        {
            long[] numbers = new long[size];
            numbers[0] = 1;

            for (long currentNumber = 1; currentNumber < numbers.Length; currentNumber++)
            {
                long sum = 0;

                for (long previousNumber = currentNumber - 1; previousNumber >= currentNumber - numbsCount; previousNumber--)
                {
                    if (previousNumber < 0)
                    {
                        break;
                    }
                    sum += numbers[previousNumber];
                }

                numbers[currentNumber] = sum;
                sum = 0;
            }

            return numbers;
        }
    }
}
