using System;

namespace P4Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            int studioNightsCount = nightsCount;

            if (nightsCount > 7 && (month == "September" || month == "October"))
            {
                studioNightsCount--;
            }


            switch (month)
            {
                case "May":
                case "October":
                    if (nightsCount > 7)
                    {
                        priceStudio = 50 * 0.95 * studioNightsCount;
                    }
                    else
                    {
                        priceStudio = 50 * studioNightsCount;
                    }

                    priceDouble = 65 * nightsCount;
                    priceSuite = 75 * nightsCount;
                    break;

                case "June":
                case "September":
                    if (nightsCount > 14)
                    {
                        priceDouble = 72 * 0.9 * nightsCount;
                    }
                    else
                    {
                        priceDouble = 72 * nightsCount;
                    }

                    priceStudio = 60 * studioNightsCount;
                    priceSuite = 82 * nightsCount;
                    break;

                case "July":
                case "August":
                case "December":
                    if (nightsCount > 14)
                    {
                        priceSuite = 89 * 0.85 * nightsCount;
                    }
                    else
                    {
                        priceSuite = 89 * nightsCount;
                    }

                    priceStudio = 68 * studioNightsCount;
                    priceDouble = 77 * nightsCount;
                    break;
            }


                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                    Console.WriteLine($"Double: {priceDouble:F2} lv.");
                    Console.WriteLine($"Suite: {priceSuite:F2} lv.");
            }
        }
    }

