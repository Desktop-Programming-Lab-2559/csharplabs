using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    class TVector3D : Vector2D
    {
        public double Z { set; get; }
        private const double EPSILON = 0.001;
        public TVector3D(double X, double Y, double z) : base(X, Y)
        {
            Z = z;
        }
        new public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        new public Vector2D Normalize()
        {
            double length = Length();
            if (length == 0) return new TVector3D(0, 0, 0);
            else return new TVector3D(X / length, Y / length, Z / length);
        }
        public static bool operator ==(TVector3D v, TVector3D v1)
        {
            return (Math.Abs(v.X - v1.X) < EPSILON && Math.Abs(v.Y - v1.Y) < EPSILON && Math.Abs(v.Z - v1.Z) < EPSILON);
        }

        public static bool operator !=(TVector3D v, TVector3D v1)
        {
            return !(v == v1);
        }
        public static TVector3D operator +(TVector3D v1, TVector3D v2)
        {
            return new TVector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static TVector3D operator -(TVector3D v1, TVector3D v2)
        {
            return new TVector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
        public static double operator *(TVector3D v1, TVector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";

        }
    }
}
