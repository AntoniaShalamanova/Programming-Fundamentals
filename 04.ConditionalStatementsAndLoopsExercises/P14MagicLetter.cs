using System;

namespace P14MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char avoidChar = char.Parse(Console.ReadLine());

            for (char firstLetter = firstChar; firstLetter <= secondChar; firstLetter++)
            {
                for (char secondLetter = firstChar; secondLetter <= secondChar; secondLetter++)
                {
                    for (char thirdLetter = firstChar; thirdLetter <= secondChar; thirdLetter++)
                    {
                        if (firstLetter != avoidChar && secondLetter != avoidChar && thirdLetter != avoidChar)
                        {
                            Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                        }
                    }
                }
            }
        }
    }
}
