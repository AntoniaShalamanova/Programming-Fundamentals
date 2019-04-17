using System;

namespace P4SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            bool[] numbers = new bool[size + 1];

            for (int i = 2; i <= size; i++)
            {
                numbers[i] = true;
            }
            
            for (int i = 2; i <= size; i++)
            {
                int currentCompositeNumber = 1;
                int multiplier = 2;

                currentCompositeNumber = i * multiplier;

                while (currentCompositeNumber <= size)
                {
                    numbers[currentCompositeNumber] = false;
                    multiplier++; 
                    currentCompositeNumber = i * multiplier;                      
                }
            }

            for (int i = 2; i <= size; i++)
            {
                if (numbers[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}


