using System;

namespace P14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decNum = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(decNum, 16).ToUpper();
            string binary = Convert.ToString(decNum, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
