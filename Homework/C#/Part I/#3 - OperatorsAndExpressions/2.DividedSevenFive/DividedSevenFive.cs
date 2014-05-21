// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

namespace DividedSevenFive
{
    class DividedSevenFive
    {
        static void Main()
        {
            bool result;
            int num;

            Console.Write("Please enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 || num % 7 == 0)
            {
                result = true;
                Console.WriteLine(num + " is: " + result);
            }
            else
            {
                result = false;
                Console.WriteLine(num + "is: " + result);
            }
        }
    }
}
