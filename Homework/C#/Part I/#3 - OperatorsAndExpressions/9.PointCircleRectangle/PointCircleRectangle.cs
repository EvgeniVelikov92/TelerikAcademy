// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x, y, r;
            bool withinCircle = false, outsideRectangle = true, point = false;

            Console.Write("Please enter X integer: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Please enter Y integer: ");
            y = double.Parse(Console.ReadLine());

            Console.Write("Please enter R integer: ");
            r = double.Parse(Console.ReadLine());

            if ((x * x) + (y * y) < (r * r))
            {
                withinCircle = true;
            }
            else
            {
                withinCircle = false;
            }

            if ((x <= -1 || x >= 6 || y <= 1 || y >= 2))
            {
                outsideRectangle = true;
            }
            else
            {
                outsideRectangle = false;
            }

            if (outsideRectangle == false)
            {
                if (withinCircle == false)
                {
                    point = false;
                    Console.WriteLine("The Point is Outside Rectangle and Without Circle");
                }
                else
                {
                    point = false;
                    Console.WriteLine("The Point is Outside Rectangle and Within Circle");
                }
            }
            else
            {
                if (withinCircle == false)
                {
                    point = false;
                    Console.WriteLine("The Point is Outside Rectangle and Without Circle");
                }
                else
                {
                    point = true;
                    Console.WriteLine("The Point is Inside Rectangle and Within Circle");
                }
            }
        }
    }
}
