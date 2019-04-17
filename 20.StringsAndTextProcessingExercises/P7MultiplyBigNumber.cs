using System;
using System.Linq;
using System.Text;

namespace P7MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            int multiplicationResult = 0;
            int rest = 0;

            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                multiplicationResult = (num1[i] - 48) * num2 + rest;

                if (multiplicationResult > 9)
                {
                    result.Append(multiplicationResult % 10).ToString();
                    rest = multiplicationResult / 10;
                }
                else
                {
                    result.Append(multiplicationResult).ToString();
                    rest = 0;
                }
            }

            if (rest > 0)
            {
                result.Append(rest).ToString();
            }

            Console.WriteLine(string.Join("", result.ToString().TrimEnd('0').Reverse()));
        }
    }
}
