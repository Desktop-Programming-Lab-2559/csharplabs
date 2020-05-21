using System;
using System.Collections.Generic;
using System.Text;

namespace lab15
{
    class Side : IMeasurable2
    {
        private double a;
        private double b;
        private double c;
        private double d;
        public double A
        {
            get { return a; }
            set
            {
                if (value < 0)
                    throw new Exception("Side must be nonegative");

                a = value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value < 0)
                    throw new Exception("Side must be nonegative");

                b = value;
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value < 0)
                    throw new Exception("Side must be nonegative");

                c = value;
            }
        }
        public double D
        {
            get { return d; }
            set
            {
                if (value < 0)
                    throw new Exception("Side must be nonegative");

                d = value;
            }
        }
        public Side(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        double IMeasurable2.Perimeter()
        {
            return a + b + c + d;
        }
        double IMeasurable2.Square()
        {
            double p = (a + b + c + d) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
        }
        string IMeasurable2.Type()
        {
            if (a == b && b == c && c == d && d == a)
            {
                return "square";
            }
            else if (a == c && b == d || a == b && c == d)
            {
                return "rectangle";
            }
            else
            {
                return "convex quadrilateral";
            }

        }

    }
}
