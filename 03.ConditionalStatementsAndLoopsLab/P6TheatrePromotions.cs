using System;

namespace P6TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine();
            int personAge = int.Parse(Console.ReadLine());

            int price = 0;

            if (personAge >= 0 && personAge <= 18)
            {
                if (typeDay == "Weekday")
                {
                    price = 12;
                }
                else if (typeDay == "Weekend")
                {
                    price = 15;
                }
                else if (typeDay == "Holiday")
                {
                    price = 5;
                }
            }
            else if (personAge > 18 && personAge <= 64)
            {
                if (typeDay == "Weekday")
                {
                    price = 18;
                }
                else if (typeDay == "Weekend")
                {
                    price = 20;
                }
                else if (typeDay == "Holiday")
                {
                    price = 12;
                }
            }
            else if (personAge > 64 && personAge <= 122)
            {
                if (typeDay == "Weekday")
                {
                    price = 12;
                }
                else if (typeDay == "Weekend")
                {
                    price = 15;
                }
                else if (typeDay == "Holiday")
                {
                    price = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }


            Console.WriteLine(price + "$");
        }
    }
}
