// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers.

using System;

namespace ReadIntegerNumber
{
    class ReadIntegerNumber
    {
        static void Main()
        {
            int start = 1;
            int end = 100;

            ReadNumber(start, end);
        }

        static void ReadNumber(int start, int end)
        {
            int[] arrNum = new int[10];
            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.Write("Input number [{0}]: ", i + 1);
                try
                {
                    arrNum[i] = int.Parse(Console.ReadLine());
                    if (arrNum[i] < start)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else if (arrNum[i] > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Format! ");
                    return;
                }
            }
        }
    }
}
