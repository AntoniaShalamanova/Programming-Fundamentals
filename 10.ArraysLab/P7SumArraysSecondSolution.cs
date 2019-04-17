using System;
using System.Linq;

namespace P7SumArraysSecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxArrCount = Math.Max(arr1.Length, arr2.Length);
            int[] newArr = new int[maxArrCount];

            int[] sumOfArr = GetSumOfArr(arr1, arr2, newArr);

            foreach (int numb in sumOfArr)
            {
                Console.Write(numb + " ");
            }
        }

        static int[] CalculateSumOfArr(int[] arr1, int[] arr2)
        {
            int[] sumOfArr = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                sumOfArr[i] = arr1[i] + arr2[i];
            }

            return sumOfArr;
        }

        static int[] GetSumOfArr(int[] arr1, int[] arr2, int[] newArr)
        {
            if (arr1.Length > arr2.Length)
            {
                MultiplicateMinArray(newArr, arr2);
                return CalculateSumOfArr(arr1, newArr);
            }
            else
            {
                MultiplicateMinArray(newArr, arr1);
                return CalculateSumOfArr(arr2, newArr);
            }
        }

        static void MultiplicateMinArray(int[] newArr, int[] minArr)
        {
            int newArrayIdx = 0;
            while (newArrayIdx < newArr.Length)
            {
                int minArrayIdx = 0;
                int n = Math.Min(newArr.Length - newArrayIdx, minArr.Length);
                while (minArrayIdx < n)
                {
                    newArr[newArrayIdx] = minArr[minArrayIdx];

                    minArrayIdx++;
                    newArrayIdx++;
                }
            }
        }
    }
}
