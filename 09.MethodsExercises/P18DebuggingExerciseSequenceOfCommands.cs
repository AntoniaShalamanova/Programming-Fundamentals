using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string line = Console.ReadLine();

        while (!line.Equals("stop"))
        {
            string[] stringParams = line.Split(ArgumentsDelimiter);
            string command = stringParams[0];
            int[] args = new int[2];
            bool isComand = false;

            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                PerformAction(array, command, args);
                isComand = true;
            }
            else if (command.Equals("lshift"))
            {
                ArrayShiftLeft(array);
                isComand = true;
            }
            else if (command.Equals("rshift"))
            {
                ArrayShiftRight(array);
                isComand = true;
            }

            if (isComand)
            {
                PrintArray(array);
            }

            line = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr;
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos - 1] *= value;
                break;
            case "add":
                array[pos - 1] += value;
                break;
            case "subtract":
                array[pos - 1] -= value;
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long lastNumber = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                array[i] = lastNumber;
            }
            else
            {
                array[i] = array[i - 1];
            }
        }
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long firstNumber = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                array[i] = firstNumber;
            }
            else
            {
                array[i] = array[i + 1];
            }
        }
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

