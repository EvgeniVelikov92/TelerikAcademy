// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

namespace CheckNumberIsPrime
{
    class CheckNumberIsPrime
    {
        static void Main()
        {
            Console.Write("Enter a positive integer number: ");
            string consoleArgument = Console.ReadLine();

            uint number = uint.Parse(consoleArgument);
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(number);
            bool prime = true;

            while (prime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }

            Console.WriteLine("Prime? {0}", prime);
        }
    }
}
