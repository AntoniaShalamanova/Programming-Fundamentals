using System;
using System.Numerics;

namespace P1CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNumber = int.Parse(Console.ReadLine());
            long runnersNumber = long.Parse(Console.ReadLine());
            int lapsNumber = int.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            if (runnersNumber > trackCapacity * daysNumber)
            {
                runnersNumber = trackCapacity * daysNumber;
            }

            BigInteger totalMeters = runnersNumber * lapsNumber * lapLength;
            decimal totalKm = (decimal)totalMeters / 1000;
            decimal raisedMoney = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {raisedMoney:F2}");
        }
    }
}
