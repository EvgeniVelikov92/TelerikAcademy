// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

namespace PointCircle
{
    class PointCircle
    {
        static void Main()
        {
            double x;
            double y;
            double r;
            double result;

            Console.Write("Please enter coordinate on X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Please enter coordinate on Y: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Please enter coordinate on R: ");
            r = double.Parse(Console.ReadLine());

            result = x * x + y * y;

            if (r >= result)
            {
                Console.WriteLine("Точката се намира във окръжността.");
            }
            else
            {
                Console.WriteLine("Точката НЕ се намира във окръжността.");
            }
        }
    }
}
