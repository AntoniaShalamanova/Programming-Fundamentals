using System;

namespace P18DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = "";
            bool canFit = false;

            try
            {
                sbyte checkNum = sbyte.Parse(number);
                result += "* sbyte\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                byte checkNum = byte.Parse(number);
                result += "* byte\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                short checkNum = short.Parse(number);
                result += "* short\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                ushort checkNum = ushort.Parse(number);
                result += "* ushort\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                int checkNum = int.Parse(number);
                result += "* int\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                uint checkNum = uint.Parse(number);
                result += "* uint\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                long checkNum = long.Parse(number);
                result += "* long\r\n";
                canFit = true;
            }
            catch { }

            if (canFit)
            {
                Console.WriteLine($"{number} can fit in:\r\n{result}");
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
