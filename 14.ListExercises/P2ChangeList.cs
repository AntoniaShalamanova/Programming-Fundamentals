using System;
using System.Linq;
using System.Collections.Generic;

namespace P2ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> comand = Console.ReadLine().Split(' ').ToList();
            int element = 0;
            int position = 0;

            while (comand[0] != "Odd" && comand[0] != "Even")
            { 

                if (comand[0] == "Delete")
                {
                    element = int.Parse(comand[1]);

                    numbers.RemoveAll(num => num == element);
                }
                else if (comand[0] == "Insert")
                {
                    element = int.Parse(comand[1]);
                    position = int.Parse(comand[2]);

                    numbers.Insert(position, element);
                }

                comand = Console.ReadLine().Split(' ').ToList(); 
            }

            if (comand[0] == "Odd")
            {
                numbers.RemoveAll(numb => numb % 2 == 0);
            }
            else if(comand[0] == "Even")
            {
                numbers.RemoveAll(numb => numb % 2 != 0);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
