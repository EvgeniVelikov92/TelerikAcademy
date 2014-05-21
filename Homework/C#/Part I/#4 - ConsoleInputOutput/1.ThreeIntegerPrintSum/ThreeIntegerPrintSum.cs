// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

namespace ThreeIntegerPrintSum
{
    class ThreeIntegerPrintSum
    {
        static void Main()
        {
            int a;
            int b;
            int c;
            int sum;

            Console.Write("Please enter a number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Please enter a number: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Please enter a number: ");
            c = int.Parse(Console.ReadLine());

            sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
