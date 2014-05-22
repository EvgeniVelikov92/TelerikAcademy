// Write a program that finds the maximal increasing sequence in an array.
using System;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int[] arr = { 3, 2, 3, 4, 5, 6, 2, 4 };
            int len = 1;
            int bestlen = 1;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] + 1) == arr[i + 1])
                {
                    len++;
                }
                else if ((arr[i] + 1) != arr[i + 1])
                {
                    len = 1;
                }

                if (len > bestlen)
                {
                    bestlen = len;
                }
            }
            Console.WriteLine("Length: {0}", bestlen);
        }
    }
}
