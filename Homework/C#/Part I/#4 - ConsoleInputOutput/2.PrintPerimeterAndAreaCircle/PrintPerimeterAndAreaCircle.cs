// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

namespace PrintPerimeterAndAreaCircle
{
    class PrintPerimeterAndAreaCircle
    {
        static void Main()
        {
            int r;
            double parametar;
            double area;

            Console.Write("Please enter a Radius: ");
            r = int.Parse(Console.ReadLine());

            parametar = 2 * Math.PI * r;
            area = Math.PI * r * r;

            Console.WriteLine("Parametar is: {0:N4}", parametar);
            Console.WriteLine();
            Console.WriteLine("Area is: {0:N4}", area);
        }
    }
}
