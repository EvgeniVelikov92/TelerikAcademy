// Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

namespace ShowTheSignNumber
{
    class ShowTheSignNumber
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

            if (first * second * third < 0)
            {
                Console.WriteLine("Знакът е -");
            }
            else if (first * second * third > 0)
            {
                Console.WriteLine("Знакът е +");
            }
            else
            {
                Console.WriteLine("Има число равно на 0");
            }
        }
    }
}
