using System;

namespace P6TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int firstLetter = 97; firstLetter <= 97 + size; firstLetter++)
            {
                for (int secondLetter = 97; secondLetter < 97 + size; secondLetter++)
                {
                    for (int thirdLetter = 97; thirdLetter < 97 + size; thirdLetter++)
                    {
                        Console.WriteLine($"{(char)firstLetter}{(char)secondLetter}{(char)thirdLetter}");
                    }
                }                
            }
        }
    }
}
