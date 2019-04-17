using System;

namespace P6StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            string text = firstWord + " " + secondWord;
            Console.WriteLine(text);
        }
    }
}
