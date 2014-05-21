// Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a;
            double b;
            double c;
            double d;
            double numOne;
            double numTwo;
            double den;
            double xOne;
            double xTwo;

            Console.Write("Please enter a number of 'a': ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Please enter a number of 'b': ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Please enter a number of 'c': ");
            c = double.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d > 0)
            {
                numOne = -b + Math.Sqrt(d);
                numTwo = -b - Math.Sqrt(d);
                den = 2 * a;
                xOne = numOne / den;
                xTwo = numTwo / den;
                Console.WriteLine(" a = {0} ;\n b = {1} ;\n c = {2} ;\n d = {3} ;\n X1 = {4} ;\n X2 = {5}", a, b, c, d, xOne, xTwo);
            }
            else if (d == 0)
            {
                numOne = -b;
                den = 2 * a;
                xOne = numOne / den;
                Console.WriteLine(" a = {0} ;\n b = {1} ;\n c = {2} ;\n d = 0 ;\n X1 = X2 = {3}", a, b, c, xOne);
            }
            else
            {
                Console.Write("This Equal is haven't Real Equal.");
            }
        }
    }
}
