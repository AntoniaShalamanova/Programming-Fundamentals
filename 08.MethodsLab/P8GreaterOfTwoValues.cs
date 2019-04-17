using System;

namespace P8GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(num1, num2));
                    break;

                case "char":
                    char firstLetter = char.Parse(Console.ReadLine());
                    char secondLetter = char.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(firstLetter, secondLetter));
                    break;

                case "string":
                    string firstWord = Console.ReadLine();
                    string secondWord = Console.ReadLine();

                    Console.WriteLine(GetMax(firstWord, secondWord));
                    break;
            }
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GetMax(char firstLetter, char secondLetter)
        {
            if (firstLetter >= secondLetter)
            {
                return firstLetter;
            }
            else
            {
                return secondLetter;
            }
        }

        static string GetMax(string firstWord, string secondWord)
        {
            if (firstWord.CompareTo(secondWord) >= 0)
            {
                return firstWord;
            }
            else
            {
                return secondWord;
            }
        }
    }
}
