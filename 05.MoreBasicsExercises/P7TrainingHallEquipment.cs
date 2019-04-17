using System;

namespace P7TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            long itemsNumber = long.Parse(Console.ReadLine());

            string itemName = "";
            decimal itemPrice = 0;
            long itemCount = 0;
            decimal subtotal = 0;

            for (int i = 0; i < itemsNumber; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = decimal.Parse(Console.ReadLine());
                itemCount = long.Parse(Console.ReadLine());

                if (itemCount != 1)
                {
                    itemName += "s";
                }

                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                subtotal += (itemPrice * itemCount);
            }

            if (subtotal > budget)
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Not enough. We need ${subtotal - budget:F2} more.");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Money left: ${budget - subtotal:F2}");
            }
        }
    }
}
