using System;

namespace _03.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: { age}");
            Console.WriteLine($"Employee ID: {ID:D8}");
            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}
