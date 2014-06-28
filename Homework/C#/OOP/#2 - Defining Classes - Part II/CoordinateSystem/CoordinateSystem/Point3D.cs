namespace CoordinateSystem
{
    using System;
    using System.Text;

    public struct Point3D
    {
        private int x;
        private int y;
        private int z;
        private static readonly int[] pointO = { 0, 0, 0 };

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static int[] PointO
        {
            get
            {
                return pointO;
            }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("{ ");
            result.Append(this.X);
            result.Append(", ");
            result.Append(this.Y);
            result.Append(", ");
            result.Append(this.Z);
            result.Append(" }");

            return result.ToString();
        }

        public int xOne { get; set; }

        public int xTwo { get; set; }

        public int yOne { get; set; }

        public int yTwo { get; set; }
    }
}
