using System;

namespace P7ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp = 0;

            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}
