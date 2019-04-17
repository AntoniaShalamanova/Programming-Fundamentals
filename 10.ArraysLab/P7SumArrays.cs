using System;
using System.Linq;

namespace P7SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxArrCount = Math.Max(arr1.Length, arr2.Length);

            int[] sumOfArr = GetSumOfArr(arr1, arr2);

            foreach (int numb in sumOfArr)
            {
                Console.Write(numb + " ");
            }
        }

        static int[] CalculateSumOfArr(int[] maxArr, int[] minArr)
        {
            int[] sumOfArr = new int[maxArr.Length];

            for (int i = 0; i < maxArr.Length; i++)
            {
                sumOfArr[i] = maxArr[i] + minArr[i % minArr.Length];
            }

            return sumOfArr;
        }

        static int[] GetSumOfArr(int[] arr1, int[] arr2) 
        {
            if (arr1.Length > arr2.Length)
            {
                return CalculateSumOfArr(arr1, arr2);
            }
            else
            {
                return CalculateSumOfArr(arr2, arr1);
            }
        }
    }
}
