// Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

namespace DivisibleByThreeAndSeven
{
    class DivisibleByThreeAndSeven
    {
        static void Main()
        {
            int n = 1;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool prime = true;

                if (i % 3 == 0 && i % 7 == 0)
                {
                    prime = false;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
