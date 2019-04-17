using System;

namespace P3EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitName(number));
        }

        static string GetLastDigitName(long number)
        {
            number = Math.Abs(number);
            long lastDigit = number % 10;
            string nameOfLastDigit = "";

            switch (lastDigit)
            {
                case 0:
                    nameOfLastDigit = "zero";
                    break;
                case 1:
                    nameOfLastDigit = "one";
                    break;
                case 2:
                    nameOfLastDigit = "two";
                    break;
                case 3:
                    nameOfLastDigit = "three";
                    break;
                case 4:
                    nameOfLastDigit = "four";
                    break;
                case 5:
                    nameOfLastDigit = "five";
                    break;
                case 6:
                    nameOfLastDigit = "six";
                    break;
                case 7:
                    nameOfLastDigit = "seven";
                    break;
                case 8:
                    nameOfLastDigit = "eight";
                    break;
                case 9:
                    nameOfLastDigit = "nine";
                    break;
            }

            return nameOfLastDigit;
        }
    }
}
