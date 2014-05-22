// Write methods that calculate the surface of a triangle by given: Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

namespace CalculateTriangle
{
    class CalculateTriangle
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            CalculateHypotenuza(a, b);
        }

        static void CalculateHypotenuza(double one, double two)
        {
            double three = one * one + two * two;
            Console.WriteLine(three);

            SQRTHypotenuza(three);
        }

        static void SQRTHypotenuza(double c)
        {
            double hypotenuse = Math.Sqrt(c);
            Console.WriteLine("{0:N}", hypotenuse);
        }
    }
}
