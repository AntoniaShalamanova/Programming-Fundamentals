using System;

namespace P1HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {GetName(name)}!");
        }

        static string GetName(string name)
        {
            return name;
        }
    }
}
