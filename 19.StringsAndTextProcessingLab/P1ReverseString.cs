using System;
using System.Text;

namespace P1ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            input.Append(Console.ReadLine());

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]); 
            }
        }
    }
}
