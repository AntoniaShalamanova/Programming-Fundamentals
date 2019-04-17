using System;

namespace P11FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int first = a; first <= b - 4; first++)
            {
                for (int second = first + 1; second <= b - 3; second++)
                {
                    for (int third = second + 1; third <= b - 2; third++)
                    {
                        for (int fourth = third + 1; fourth <= b - 1; fourth++)
                        {
                            for (int fifth = fourth + 1; fifth <= b; fifth++)
                            {
                                Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                            }
                        }
                    }
                }
            }
        }
    }
}
