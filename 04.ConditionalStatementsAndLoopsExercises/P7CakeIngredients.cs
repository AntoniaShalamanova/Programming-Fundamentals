using System;

namespace P7CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredientName = "";
            int count = 0;

            ingredientName = Console.ReadLine();

            while (ingredientName != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredientName}.");
                count++;
                ingredientName = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
