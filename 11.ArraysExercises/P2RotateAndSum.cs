using System;
using System.Linq;

namespace P2RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationNumber = int.Parse(Console.ReadLine());

            
            int[] sumArr = new int[arr.Length];

            for (int i = 0; i < rotationNumber; i++)
            {
                arr = ReverseArr(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    sumArr[j] += arr[j];
                }
            }

            foreach (int numb in sumArr)
            {
                Console.Write(numb + " ");
            }
        }

        static int[] ReverseArr(int[] arr)
        {
            int lastElament = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElament;

            return arr;
        }
    }
}
