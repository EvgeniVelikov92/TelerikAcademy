namespace CoordinateSystem
{
    using System;

    public static class DistancePoint
    {
        private static int x;
        private static int y;
        private static int z;
        public static Point3D pointOne = new Point3D();
        public static Point3D pointTwo = new Point3D();

        static DistancePoint()
        {
            pointOne.X = x;
            pointOne.Y = y;
            pointTwo.X = x;
            pointTwo.Y = y;
        }

        public static int CalculateDistance(double xOne, double xTwo, double yOne, double yTwo)
        {
            return ((pointOne.xOne - pointTwo.xTwo) * (pointOne.xOne + pointTwo.xTwo) + (pointOne.yOne - pointTwo.yTwo) * (pointOne.yOne - pointTwo.yTwo));
        }
    }
}