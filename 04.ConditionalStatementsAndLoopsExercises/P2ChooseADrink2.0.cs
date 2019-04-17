using System;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string drink = "";
            double totalPrice = 0;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    totalPrice = quantity * 0.7;
                    break;

                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    totalPrice = quantity;
                    break;

                case "SoftUni Student":
                    drink = "Beer";
                    totalPrice = quantity * 1.7;
                    break;

                default:
                    drink = "Tea";
                    totalPrice = quantity * 1.2;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
