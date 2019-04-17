using System;
using System.Linq;
using System.Collections.Generic;

namespace P5ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] comandsParam = Console.ReadLine().Split(' ').ToArray();

            while (comandsParam[0] != "print")
            {
                switch (comandsParam[0])
                {
                    case "add":
                        {
                            int index = int.Parse(comandsParam[1]);
                            int element = int.Parse(comandsParam[2]);

                            numbers.Insert(index, element);

                            break;
                        }
                    case "addMany":
                        {
                            int index = int.Parse(comandsParam[1]);

                            string[] elements = comandsParam.Skip(2).ToArray();

                            numbers.InsertRange(index, elements.Select(int.Parse));

                            break;
                        }
                    case "contains":
                        {
                            int element = int.Parse(comandsParam[1]);

                            if (numbers.Contains(element))
                            {
                                Console.WriteLine(numbers.IndexOf(element));
                            }
                            else
                            {
                                Console.WriteLine(-1);
                            }

                            break;
                        }
                    case "remove":
                        {
                            int index = int.Parse(comandsParam[1]);

                            numbers.RemoveAt(index);

                            break;
                        }
                    case "shift":
                        {
                            int position = int.Parse(comandsParam[1]) % numbers.Count;

                            List<int> shiftedNumbersList = numbers.Skip(position).ToList();

                            for (int i = 0; i < position; i++)
                            {
                                shiftedNumbersList.Add(numbers[i]);
                            }

                            numbers = shiftedNumbersList;

                            break;
                        }
                    case "sumPairs":
                        {
                            int count = numbers.Count / 2;

                            for (int i = 0; i < count; i++)
                            {
                                numbers[i] = numbers[i] + numbers[i + 1];
                                numbers.RemoveAt(i + 1);
                            }

                            break;
                        }
                }

                comandsParam = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
