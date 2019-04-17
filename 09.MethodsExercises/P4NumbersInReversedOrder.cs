using System;

namespace P4NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(GetReverseNumber(number));
        }

        static string GetReverseNumber(double number)
        {
            string numberToString = number.ToString();
            string reverseNumber = "";

            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                reverseNumber += numberToString[i];
            }

            return reverseNumber;
        }
    }
}
