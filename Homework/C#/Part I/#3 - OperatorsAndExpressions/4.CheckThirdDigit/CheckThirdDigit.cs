// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 --> true.

using System;

namespace CheckThirdDigit
{
    class CheckThirdDigit
    {
        static void Main()
        {
            int num;
            int hund;

            Console.Write("Please enter a number (100-999): ");
            num = int.Parse(Console.ReadLine());

            hund = num / 100;

            if (hund % 7 == 0)
            {
                Console.WriteLine("The tird number is: {0}", hund);
            }
            else
            {
                Console.WriteLine("The tird number is: {0}", hund);
            }
        }
    }
}
