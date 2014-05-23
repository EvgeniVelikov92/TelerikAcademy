// Write a program that finds the sequence of maximal sum in given array.

using System;

namespace SequenceMaxSum
{
    class SequenceMaxSum
    {
        static void Main()
        {
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int bestSum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
