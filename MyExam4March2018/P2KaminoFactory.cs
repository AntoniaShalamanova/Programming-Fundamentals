using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequencesLength = int.Parse(Console.ReadLine());
            string currentSequence = Console.ReadLine();
            int sequenceCount = 0;
            //sequence -> key // maxLength, startIndx, sequenceIndx
            Dictionary<int[], List<int>> sequences = new Dictionary<int[], List<int>>();

            while (currentSequence != "Clone them!")
            {
                int[] numbers = currentSequence.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sequenceCount++;

                bool isCorrect = true;

                foreach (var num in numbers)
                {
                    if (num != 0 && num != 1)
                    {
                        isCorrect = false;
                    }
                }

                if (numbers.Length == sequencesLength && isCorrect)
                {
                    int count = 1;
                    int maxLength = 0;
                    int indx = 0;

                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] == 1)
                        {
                            count++;
                        }
                        else
                        {
                            if (maxLength < count)
                            {
                                maxLength = count;
                                indx = i - count;
                            }
                            count = 1;
                        }
                    }

                    if (maxLength < count)
                    {
                        maxLength = count;
                    }

                    sequences.Add(numbers, new List<int> { maxLength, indx, sequenceCount });
                }

                currentSequence = Console.ReadLine();
            }


            KeyValuePair<int[], List<int>> sequence = sequences
                .OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Value[1])
                .ThenByDescending(x => x.Key.Sum())
                .First();

            Console.WriteLine($"Best DNA sample {sequence.Value[2]} with sum: {sequence.Key.Sum()}.");
            Console.WriteLine(string.Join(" ", sequence.Key));
        }
    }
}
