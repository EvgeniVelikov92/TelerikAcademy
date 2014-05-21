// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

namespace TrapezoidArena
{
    class TrapezoidArena
    {
        static void Main()
        {
            double a;
            double b;
            double h;
            double s;

            Console.Write("Please enter a number of 'a': ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Please enter a number of 'b': ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Please enter a number of 'h': ");
            h = double.Parse(Console.ReadLine());

            s = ((a + b) / 2) * h;
            Console.WriteLine(s);
        }
    }
}
