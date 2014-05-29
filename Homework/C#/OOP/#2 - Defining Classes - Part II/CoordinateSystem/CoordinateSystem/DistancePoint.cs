namespace CoordinateSystem
{
    public static class DistancePoint
    {
        private int x;
        private int y;
        private int z;
        public Point3D point = new Point3D();

        public DistancePoint()
        {
            this.point.X = x;
            this.point.Y = y;
            this.point.Z = z;
        }

        public static int CalculateDistance(int x, int y, int z)
        {
            return 0;
        }
    }
}
