using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace P6SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            int rest = 0;
            int sum = 0;

            if (num1.Length < num2.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }
            else if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                sum = (num1[i] - 48) + (num2[i] - 48) + rest;

                if (sum > 9)
                {
                    result.Append(sum % 10).ToString();
                    rest = sum / 10;
                }
                else
                {
                    result.Append(sum.ToString());
                    rest = 0;
                }
            }

            if (rest > 0)
            {
                result.Append(rest);
            }

            Console.WriteLine(string.Join("", result.ToString().TrimEnd('0').Reverse()));
        }
    }
}
