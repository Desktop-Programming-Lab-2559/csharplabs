using System;
using System.Collections.Generic;
using System.Text;

namespace lab15
{
    class Coords : IMeasurable1
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }
        public Coords(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;
        }


        double IMeasurable1.Perimeter()
        {
            double AB = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
            double DC = Math.Sqrt((X4 - X3) * (X4 - X3) + (Y4 - Y3) * (Y4 - Y3));
            double BD = Math.Sqrt((X3 - X2) * (X3 - X2) + (Y3 - Y2) * (Y3 - Y2));
            double AC = Math.Sqrt((X4 - X1) * (X4 - X1) + (Y4 - Y1) * (Y4 - Y1));
            return AB + BD + DC + AC;
        }


        double IMeasurable1.Square()
        {
            return Math.Abs(X1 * Y2 + X2 * Y3 + X3 * Y4 + X4 * Y1 - X2 * Y1 - X3 * Y2 - X4 * Y3 - X1 * Y4);
        }
        string IMeasurable1.Type()
        {
            double AB = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
            double DC = Math.Sqrt((X4 - X3) * (X4 - X3) + (Y4 - Y3) * (Y4 - Y3));
            double BD = Math.Sqrt((X3 - X2) * (X3 - X2) + (Y3 - Y2) * (Y3 - Y2));
            double AC = Math.Sqrt((X4 - X1) * (X4 - X1) + (Y4 - Y1) * (Y4 - Y1));
            if (AB == DC && DC == BD && BD == AC && AC == AB)
            {
                return "square";
            }
            else if (AB == DC && BD == AC || AB == BD && DC == AC)
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
