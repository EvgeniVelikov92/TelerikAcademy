// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            int first;
            int second;
            int bigStrong;

            Console.Write("Please enter a number: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter a number: ");
            second = int.Parse(Console.ReadLine());

            bigStrong = Math.Max(first, second);
            Console.WriteLine(" " + bigStrong);
        }
    }
}
