using System;

namespace P6DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            string range = "ACGT";
            int sum = 0;
            string currentSequence = "";
            int sequenceCount = 0;

            for (int firstLetter = 0; firstLetter < range.Length; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < range.Length; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < range.Length; thirdLetter++)
                    {
                        currentSequence += range[firstLetter];
                        currentSequence += range[secondLetter];
                        currentSequence += range[thirdLetter];

                        for (int i = 0; i < currentSequence.Length; i++)
                        {
                            if (currentSequence[i] == 'A')
                            {
                                sum += 1;
                            }
                            else if (currentSequence[i] == 'C')
                            {
                                sum += 2;
                            }
                            else if (currentSequence[i] == 'G')
                            {
                                sum += 3;
                            }
                            else if (currentSequence[i] == 'T')
                            {
                                sum += 4;
                            }
                        }

                        if (sequenceCount % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                        if (sum >= matchSum)
                        {
                            Console.Write($"O{range[firstLetter]}{range[secondLetter]}{range[thirdLetter]}O ");
                        }
                        else
                        {
                            Console.Write($"X{range[firstLetter]}{range[secondLetter]}{range[thirdLetter]}X ");
                        }
                        sequenceCount++;

                        currentSequence = "";
                        sum = 0;
                    }
                }
            }
        }
    }
}
