// Write a program that prints all the numbers from 1 to N.

using System;

namespace PrintNNumbers
{
    class PrintNNumbers
    {
        static void Main()
        {
            int n;

            Console.Write("Please enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
