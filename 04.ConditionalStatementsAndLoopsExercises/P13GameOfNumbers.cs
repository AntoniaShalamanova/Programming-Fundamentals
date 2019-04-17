using System;

namespace P13GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginNumb = int.Parse(Console.ReadLine());
            int endNumb = int.Parse(Console.ReadLine());
            int magicalNumb = int.Parse(Console.ReadLine());

            int count = 0;
            string equalCombination = "";
            for (int firstNum = beginNumb; firstNum <= endNumb; firstNum++)
            {
                for (int secondNum = beginNumb; secondNum <= endNumb; secondNum++)
                {
                    count++;
                    if (firstNum + secondNum == magicalNumb)
                    {
                        equalCombination = firstNum.ToString() + " + " + secondNum.ToString() + " = " + magicalNumb.ToString();
                    }
                }
            }

            if (equalCombination == "")
            {
                Console.WriteLine($"{count} combinations - neither equals {magicalNumb}");
            }
            else
            {
                Console.WriteLine($"Number found! {equalCombination}");
            }
        }
    }
}
