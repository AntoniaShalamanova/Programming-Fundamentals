using System;
using System.Linq;

namespace P1LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            int sizeOfShort = Math.Min(arr1.Length, arr2.Length);
            int sizeOfLong = Math.Max(arr1.Length, arr2.Length);

            int countFromLeeft = 0;

            for (int i = 0; i < sizeOfShort; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    countFromLeeft++;
                }
                else
                {
                    break;
                }
            }

            int endOfArr1 = arr1.Length;
            int endOfArr2 = arr2.Length;
            string[] shortArr = new string[sizeOfShort]; 
            string[] longArr = new string[sizeOfLong];

            if (endOfArr1 > endOfArr2)
            {
                longArr = arr1;
                shortArr = arr2;
            }
            else
            {
                longArr = arr2;
                shortArr = arr1;
            }

            int countFromRight = 0;
            int j = sizeOfLong - 1;
            for (int i = sizeOfShort - 1; i >= 0; i--)
            {
                if (shortArr[i] == longArr[j])
                {
                    countFromRight++;
                }
                else
                {
                    break;
                }
                j--;
            }

            if (countFromLeeft > countFromRight)
            {
                Console.WriteLine(countFromLeeft);
            }
            else
            {
                Console.WriteLine(countFromRight);
            }
        }
    }
}
