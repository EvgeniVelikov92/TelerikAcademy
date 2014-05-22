// Write a program that finds the maximal sequence of equal elements in an array.

using System;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int[] arr = { 2, 1, 1, 3, 3, 2, 2, 2, 1 };
            int len = 1;
            int bestlen = 1;
            int arrIndex = 0;

            for (var i = 0; i < arr.Length - 1; i++) 
            {
                if (arr[i] == arr[i + 1]) 
                {
                    len++;
                }
                else if (arr[i] != arr[i + 1]) 
                {
                    len = 1;
                }
        
                if (len > bestlen) 
                {
                    bestlen = len;
                    arrIndex = arr[i];
                }
            }
            Console.WriteLine("Index: {0} = Length: {1}", arrIndex, bestlen);
        }
    }
}
