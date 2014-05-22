// Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;

namespace CheckTheNumber
{
    class CheckTheNumber
    {
        public static void GetArray(params int[] number)
        {
            int bestSum = 0;
            int sum = 1;
            int elem = 0;

            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] == number[i + 1])
                {
                    sum++;
                }
                else if (number[i] != number[i + 1])
                {
                    sum = 1;
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    elem = number[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("The number: " + elem);
            Console.WriteLine("The length: " + bestSum);
        }

        public static void Main(string[] args)
        {
            int[] num = { 2, 3, 5, 7, 4, 6, 8, 3, 2, 4, 6, 7, 9, 3, 6, 8, 3, 2, 4, 8, 4, 2, 5, 4 };

            Array.Sort(num);

            for (int index = 0; index < num.Length; index++)
            {
                Console.Write(num[index] + " ");
            }

            GetArray(num);
        }
    }
}
