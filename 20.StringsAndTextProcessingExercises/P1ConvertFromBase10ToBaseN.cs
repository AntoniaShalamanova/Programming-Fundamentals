using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P1ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            int numeralSystem = int.Parse(input[0]);
            BigInteger decimalNumber = BigInteger.Parse(input[1]);

            BigInteger remainder = new BigInteger();
            string result = "";

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % numeralSystem;
                decimalNumber /= numeralSystem;
                result = remainder.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}
