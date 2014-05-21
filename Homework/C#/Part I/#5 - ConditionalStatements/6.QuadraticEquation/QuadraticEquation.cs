// Write a program that enters the coefficients a, b and c of a quadratic equation. a*x2 + b*x + c = 0. and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

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
                den = 2 * c;
                xOne = numOne / den;
                xTwo = numTwo / den;
                Console.WriteLine("D  = {0:N2}\nX1 = {1:N2}\nX2 = {2:N2}", d, xOne, xTwo);
            }
            else if (d == 0)
            {
                numOne = -b;
                den = 2 * c;
                xOne = numOne / den;
                Console.WriteLine("D = 0\nX1 = X2 = {0:N2}", xOne);
            }
            else
            {
                Console.WriteLine("Квадратното уравнение няма реални корени");
            }
        }
    }
}
