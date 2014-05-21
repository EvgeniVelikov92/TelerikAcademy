// Write an expression that checks if given integer is odd or even.

using System;

namespace OddEvenInteger
{
    class OddEvenInteger
    {
        static void Main()
        {
            int num;

            Console.Write("Please enter a integer number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The Number {0} is Even", num);
            }
            else
            {
                Console.WriteLine("The Number {0} is Odd", num);
            }
        }
    }
}
