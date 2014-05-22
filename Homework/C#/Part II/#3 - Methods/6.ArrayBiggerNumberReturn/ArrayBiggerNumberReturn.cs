// Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.

using System;

namespace ArrayBiggerNumberReturn
{
    class ArrayBiggerNumberReturn
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
                if (bigNumber[index] > bigNumber[index + 1] && bigNumber[index] > bigNumber[index - 1])
                {
                    Console.WriteLine(bigNumber[index]);
                    return;
                }
                else
                {
                    Console.WriteLine("-1");
                    return;
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
