namespace CoordinateSystem
{
    using System;

    public class Test
    {
        static void Main()
        {
            Point3D point = new Point3D();

            point.X = 4;
            point.Y = 3;
            point.Z = 2;

            Console.WriteLine(point);

            Console.WriteLine(DistancePoint.CalculateDistance(8, 3, 2, 5));
        }
    }
}