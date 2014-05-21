// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

namespace TwoIntegerGreater
{
    class TwoIntegerGreater
    {
        static void Main()
        {
            decimal first;
            decimal second;
            decimal greater;

            Console.Write("Please enter a first number:  ");
            first = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter a second number: ");
            second = decimal.Parse(Console.ReadLine());

            if (first > second)
            {
                greater = first;
                first = second;
                second = greater;
                Console.WriteLine("{0} and {1}", first, second);
            }
            else
            {
                Console.WriteLine("{0} and {1}", first, second);
            }
        }
    }
}
