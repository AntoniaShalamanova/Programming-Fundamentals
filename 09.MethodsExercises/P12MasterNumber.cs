using System;

namespace P12MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumDigitsDiv7(i) && HasEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumDigitsDiv7(int i)
        {
            int number = i;
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool HasEvenDigit(int i)
        {
            int number = i;
            int currentDigit = 0;

            while (number != 0)
            {
                currentDigit = number % 10;
                if (number % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }

        static bool IsPalindrome(int i)
        {
            int number = i;
            int reversed = 0;

            while (number != 0)
            {
                reversed *= 10;
                reversed += number % 10;
                number /= 10;
            }

            if (reversed == i)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
