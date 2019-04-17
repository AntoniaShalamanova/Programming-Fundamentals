using System;
using System.Linq;

namespace P2Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldsSize = int.Parse(Console.ReadLine());
            int[] ladybugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] fields = new int[fieldsSize];

            fields = FillTheField(fields, fieldsSize, ladybugsIndexes);

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] comand = input.Split(' ').ToArray();
                int index = int.Parse(comand[0]);
                string direction = comand[1];
                int length = int.Parse(comand[2]);

                if (direction == "right")
                {
                    if (index >= 0 && index < fields.Length && fields[index] == 1)
                    {
                        fields = MoveToRight(fields, index, length);
                    }
                }
                else if(direction == "left")
                {
                    if (index >= 0 && index < fields.Length && fields[index] == 1)
                    {
                        fields = MoveToLeft(fields, index, length);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var field in fields)
            {
                Console.Write(field + " ");
            }
        }

        static int[] MoveToLeft(int[] fields, int index, int length)
        {
            long landingPosition = index - length;
            fields[index] = 0;

            if (landingPosition >= 0 && landingPosition < fields.Length)
            {
                while (fields[landingPosition] == 1)
                {
                    landingPosition--;

                    if (landingPosition < 0 || landingPosition >= fields.Length)
                    {
                        return fields;
                    }
                }

                fields[landingPosition] = 1;
            }

            return fields;
        }

        static int[] MoveToRight(int[] fields, int index, int length)
        {
            long landingPosition = index + length;
            fields[index] = 0;

            if (landingPosition >= 0 &&  landingPosition < fields.Length)
            {
                while (fields[landingPosition] == 1)
                {
                    landingPosition++;

                    if (landingPosition < 0 || landingPosition >= fields.Length)
                    {
                        return fields;
                    }
                }

                fields[landingPosition] = 1;
            }

            return fields;
        }

        static int[] FillTheField(int[] fields, int fieldsSize, int[] ladybugsIndexes)
        {
            for (int i = 0; i < fieldsSize; i++)
            {
                if (ladybugsIndexes.Contains(i))
                {
                    fields[i] = 1;
                }
                else
                {
                    fields[i] = 0;
                }
            }

            return fields;
        }
    }
}
