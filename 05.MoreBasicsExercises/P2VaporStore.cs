using System;

namespace P2VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double beginBalance = double.Parse(Console.ReadLine());
            double currentBalance = beginBalance;

            string gameName;
            double gamePrice = 0;

            while (true)
            {
                gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;

                    case "CS: OG":
                        gamePrice = 15.99;
                        break;

                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;

                    case "Honored 2":
                        gamePrice = 59.99;
                        break;

                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;

                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;

                    case "Game Time":
                        Console.WriteLine($"Total spent: ${beginBalance-currentBalance:F2}. Remaining: ${currentBalance:F2}");
                        return;

                    default:
                        Console.WriteLine("Not Found");
                        continue;
                        break;
                }

                if (currentBalance - gamePrice > 0)
                {
                    Console.WriteLine($"Bought {gameName}");
                    currentBalance -= gamePrice;
                }
                else if (currentBalance - gamePrice == 0)
                {
                    Console.WriteLine($"Bought {gameName}");
                    Console.WriteLine("Out of money!");
                    return;
                }
                else if (currentBalance - gamePrice < 0)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
            }
        }
    }
}
