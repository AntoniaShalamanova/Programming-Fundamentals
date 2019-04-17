using System;
using System.Collections.Generic;
using System.Linq;

namespace P2AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dataArray = Console.ReadLine().Split(' ').ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commandLine = input.Split(' ').ToArray();
                string comand = commandLine[0];

                switch (comand)
                {
                    case "merge":
                        {
                            int startIndx = int.Parse(commandLine[1]);
                            int endIndx = int.Parse(commandLine[2]);

                            dataArray = GetMergeArray(startIndx, endIndx, dataArray);
                            break;
                        }
                    case "divide":
                        {
                            int indx = int.Parse(commandLine[1]);
                            int partitions = int.Parse(commandLine[2]);

                            dataArray = GetDivideArray(indx, partitions, dataArray);

                            break;
                        }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", dataArray));
        }

        static List<string> GetDivideArray(int indx, int partitions, List<string> dataArray)
        {
            int idx = ChangeIndex(indx, dataArray.Count);
            string wordToDivide = dataArray[idx];
            List<string> subArray = new List<string>();
            int symbolsCount = 0;

            if (partitions > 0 && partitions <= wordToDivide.Length)
            {
                symbolsCount = wordToDivide.Length / partitions;

                while (wordToDivide.Length >= symbolsCount)
                {
                    subArray.Add(wordToDivide.Substring(0, symbolsCount));
                    wordToDivide = wordToDivide.Remove(0, symbolsCount);
                }

                if (wordToDivide.Length != 0)
                {
                    subArray[subArray.Count - 1] += wordToDivide;
                }

                dataArray.RemoveAt(idx);
                dataArray.InsertRange(idx, subArray);
            }

            return dataArray;
        }

        static List<string> GetMergeArray(int startIndx, int endIndx, List<string> dataArray)
        {
            string newString = "";
            int startIdx = ChangeIndex(startIndx, dataArray.Count);
            int endIdx = ChangeIndex(endIndx, dataArray.Count);

            for (int i = startIdx; i <= endIdx; i++)
            {
                newString += dataArray[i];
            }

            dataArray.RemoveRange(startIdx, endIdx - startIdx + 1);
            dataArray.Insert(startIdx, newString);

            return dataArray;
        }

        private static int ChangeIndex(int index, int maxLength)
        {
            if (index < 0)
            {
                index = 0;
            }

            if (index >= maxLength)
            {
                index = maxLength - 1;
            }

            return index;
        }
    }
}
