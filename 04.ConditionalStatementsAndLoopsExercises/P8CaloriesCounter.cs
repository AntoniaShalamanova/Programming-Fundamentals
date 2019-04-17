using System;

namespace P8CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientsNumber = int.Parse(Console.ReadLine());

            string ingredient = "";
            int calories = 0;

            for (int i = 0; i < ingredientsNumber; i++)
            {
                ingredient =  Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    calories += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredient == "salami")
                {
                    calories += 600;
                }
                else if (ingredient == "pepper")
                {
                    calories += 50;
                }
            }

            Console.WriteLine("Total calories: " + calories);
        }
    }
}
