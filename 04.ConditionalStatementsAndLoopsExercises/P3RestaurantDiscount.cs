using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            int priceHall = 0;
            int pricePackage = 0;
            string hallName = "";

            if (groupSize <= 50)
            {
                priceHall = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                priceHall = 5000;
                hallName = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                priceHall = 7500;
                hallName = "Great Hall";
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            int discount = 0;
            if (package == "Normal")
            {
                pricePackage = 500;
                discount = 5;
            }
            else if (package == "Gold")
            {
                pricePackage = 750;
                discount = 10;
            }
            else if (package == "Platinum")
            {
                pricePackage = 1000;
                discount = 15;
            }

            int totalPrice = priceHall + pricePackage;
            double priceWithDiscount = totalPrice - (totalPrice * discount / 100);
            double pricePerPerson = priceWithDiscount / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
