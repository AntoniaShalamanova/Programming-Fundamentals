using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P2ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '.'}).ToArray();

            int numeralSystem = int.Parse(input[0]);
            BigInteger digitNumber = BigInteger.Parse(input[1]);
            BigInteger fracNumber = new BigInteger();
            BigInteger result = new BigInteger();

            try
            {
                fracNumber = BigInteger.Parse(input[2]);
            }
            catch(IndexOutOfRangeException)
            {
                fracNumber = 0;
            }

            int power = 0;
            while (digitNumber != 0)
            {
                result += (digitNumber % 10) * (BigInteger)Math.Pow(numeralSystem, power);
                digitNumber /= 10;
                power++;
            }

            power = -1;
            
            if ((fracNumber != null) && (fracNumber != 0))
            {
                char[] array = fracNumber.ToString().ToCharArray();
                Array.Reverse(array);
                String fracNumberToStr = new String(array);

                fracNumber = BigInteger.Parse(fracNumberToStr);
                result += (fracNumber % 10) * (BigInteger)Math.Pow(numeralSystem, power);
                fracNumber /= 10;
                power--;
            }

            Console.WriteLine(result);
        }
    }
}
