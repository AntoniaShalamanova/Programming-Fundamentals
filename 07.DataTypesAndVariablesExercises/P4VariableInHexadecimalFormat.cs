using System;

namespace P4VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNumb = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexNumb, 16));
        }
    }
}
