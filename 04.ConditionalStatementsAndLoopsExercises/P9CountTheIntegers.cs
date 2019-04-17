using System;

namespace P9CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int count = 0;

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
