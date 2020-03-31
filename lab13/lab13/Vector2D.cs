using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    class Vector2D
    {
        public double X { set; get; }
        public double Y { set; get; }
        private const double EPSILON = 0.001;
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";

        }
        public Vector2D(Vector2D previousVector2D)
        {
            X = previousVector2D.X;
            Y = previousVector2D.Y;
        }
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public Vector2D Normalize()
        {
            double length = Length();
            if (length == 0) return new Vector2D(0, 0);
            else return new Vector2D(X / length, Y / length);
        }

        public static bool operator ==(Vector2D v, Vector2D v1)
        {
            return (Math.Abs(v.X - v1.X) < EPSILON && Math.Abs(v.Y - v1.Y) < EPSILON);
        }
        public static bool operator !=(Vector2D v, Vector2D v1)
        {
            return !(v == v1);
        }
        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector2D operator -(Vector2D c1, Vector2D c2)
        {
            return new Vector2D(c1.X - c2.X, c1.Y - c2.Y);
        }
        public static double operator *(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }
    }
}
