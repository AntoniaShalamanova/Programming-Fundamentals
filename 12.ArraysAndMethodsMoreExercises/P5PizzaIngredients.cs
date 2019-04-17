using System;
using System.Linq;

namespace P5PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            int searchedLength = int.Parse(Console.ReadLine());

            string[] correctIngredients = new string[ingredients.Length];
            int countCorrectIngredients = 0;

            foreach (string ingredient in ingredients)
            {
                if (countCorrectIngredients + 1 > 10)
                {
                    break;
                }
                if (ingredient.Length == searchedLength)
                {
                    Console.WriteLine($"Adding {ingredient}.");
                    correctIngredients[countCorrectIngredients] = ingredient;
                    countCorrectIngredients++;
                }
            }

            Console.WriteLine($"Made pizza with total of {countCorrectIngredients} ingredients.");
            Console.Write("The ingredients are: ");

            for (int i = 0; i < countCorrectIngredients; i++)
            {
                if (i == countCorrectIngredients - 1)
                {
                    Console.WriteLine(correctIngredients[i] + ".");
                }
                else
                {
                    Console.Write(correctIngredients[i] + ", ");
                }
            }
        }
    }
}
