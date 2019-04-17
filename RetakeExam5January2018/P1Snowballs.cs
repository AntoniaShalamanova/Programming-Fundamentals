using System;
using System.Numerics;

namespace P1Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsNumber = int.Parse(Console.ReadLine());

            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;

            int[] result = new int[3];

            BigInteger maxSnowballValue = -1;

            for (int i = 0; i < snowballsNumber; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;

                    result[0] = snowballSnow;
                    result[1] = snowballTime;
                    result[2] = snowballQuality;
                } 
            }

            Console.WriteLine($"{result[0]} : {result[1]} = {maxSnowballValue} ({result[2]})");
        }
    }
}
