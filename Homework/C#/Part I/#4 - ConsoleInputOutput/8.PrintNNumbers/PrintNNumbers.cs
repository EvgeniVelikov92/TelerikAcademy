// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

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
                Console.WriteLine(i);
            }
        }
    }
}
