// Write an expression that calculates rectangle’s area by given width and height.

using System;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            double a;
            double b;
            double s;

            Console.Write("Please enter a number of 'a': ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Please enter a number of 'b': ");
            b = double.Parse(Console.ReadLine());

            s = a * b;
            Console.WriteLine("The Area: S = {0}", s);
        }
    }
}
