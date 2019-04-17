using System;

namespace P8SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int charactersNumber = int.Parse(Console.ReadLine());

            int number = 0;
            string text = "";
            int offset = 0;
            int mainDigit = 0;
            int letterIndex = 0;
            int asciiCode = 0;

            for (int i = 0; i < charactersNumber; i++)
            {
                number = int.Parse(Console.ReadLine());

                mainDigit = number % 10;
                offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                letterIndex = offset + number.ToString().Length - 1;

                asciiCode = letterIndex + 97;
                if (asciiCode == 91)
                {
                    asciiCode = 32;
                }

                text += (char)asciiCode;
            }

            Console.WriteLine(text);
        }
    }
}
