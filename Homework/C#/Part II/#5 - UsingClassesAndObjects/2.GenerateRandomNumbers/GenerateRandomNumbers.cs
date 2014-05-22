// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

namespace GenerateRandomNumbers
{
    class GenerateRandomNumbers
    {
        static void Main()
        {
            Random randNum = new Random();
            int[] arr = new int[10];

            for (int index = 1; index < arr.Length; index++)
            {
                arr[index] = randNum.Next(100, 201);
                Console.Write(arr[index] + " ");
            }
        }
    }
}
