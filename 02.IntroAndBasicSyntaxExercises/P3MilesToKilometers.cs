using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
	//convert miles to double number
            double miles = double.Parse(Console.ReadLine());

	// print kilometers to the second digit after the decimal point 
            Console.WriteLine($"{miles * 1.60934:F2}");
        }
    }
}
