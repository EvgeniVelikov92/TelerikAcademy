// Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

namespace GiveArrayBiggerNumbers
{
    class GiveArrayBiggerNumbers
    {
        static void GiveRandomNumber(int n)
        {
            int[] number = new int[n];
            Random randNum = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = randNum.Next(1, 100);
                Console.Write(number[i] + " ");
            }

            Console.WriteLine();

            GiveArrayBiggerNumber(number);
        }

        static void GiveArrayBiggerNumber(int[] bigNumber)
        {
            for (int index = 1; index < bigNumber.Length - 1; index++)
            {
                bool res = false;

                if (bigNumber[index] > bigNumber[index + 1] && bigNumber[index] > bigNumber[index - 1])
                {                   
                    Console.WriteLine(bigNumber[index]);
                    res = true;
                    return;
                }

                if (res == false)
                {
                    Console.WriteLine("Is bigger than its two neighbors!");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter your Length Array: ");
            int num = int.Parse(Console.ReadLine());

            GiveRandomNumber(num);
        }
    }
}
