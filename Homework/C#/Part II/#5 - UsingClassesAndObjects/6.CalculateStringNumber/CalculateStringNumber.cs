// You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:

using System;

namespace CalculateStringNumber
{
    class CalculateStringNumber
    {
        static void Main()
        {
            Console.Write("Please enter a numbers: ");
            int arr = int.Parse(Console.ReadLine());

            string[] number = new string[arr];
            int sum = 0;

            for (int index = 0; index < number.Length; index++)
            {
                Console.Write("[{0}] = ", index);
                number[index] = Console.ReadLine();
                sum += int.Parse(number[index]);
            }
            Console.WriteLine("The SUM is --> " + sum);
        }
    }
}
