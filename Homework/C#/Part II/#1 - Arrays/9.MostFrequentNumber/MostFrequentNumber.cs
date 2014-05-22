// Write a program that finds the most frequent number in an array.

using System;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            int[] arr = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 3, 3, 3, 3, 3, 4, 3};
            int len = 1, bestlen = 1, arrIndex = 0;

            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++) 
            {
                if (arr[i] == arr[i + 1]) 
                {
                    len++;
                }
                else 
                {
                    len = 1;
                }

                if (bestlen < len) 
                {
                    bestlen = len;
                    arrIndex = arr[i];
                }
            }

            Console.WriteLine("Index: " + arrIndex + " = Length: " + bestlen);
        }
    }
}
