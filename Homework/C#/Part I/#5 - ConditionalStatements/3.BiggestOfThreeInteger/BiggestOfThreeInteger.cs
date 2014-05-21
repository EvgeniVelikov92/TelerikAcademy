// Write a program that finds the biggest of three integers using nested if statements.

using System;

namespace BiggestOfThreeInteger
{
    class BiggestOfThreeInteger
    {
        static void Main()
        {
            int first;
            int second;
            int third;

            Console.Write("Please enter a number: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter a number: ");
            second = int.Parse(Console.ReadLine());

            Console.Write("Please enter a number: ");
            third = int.Parse(Console.ReadLine());

            if (third > second && third > first)
            {
                Console.WriteLine(third);
            }
            else if (second > third && second > first)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(first);
            }
        }
    }
}
