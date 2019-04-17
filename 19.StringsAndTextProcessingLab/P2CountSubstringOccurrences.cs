using System;

namespace P2CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string searchingString = Console.ReadLine().ToLower();

            int counter = 0;
            int indx = text.IndexOf(searchingString);

            while (indx != -1)
            {
                counter++;

                indx = text.IndexOf(searchingString, indx + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
