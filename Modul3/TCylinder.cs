using System;
using System.Collections.Generic;
using System.Text;

namespace Modul
{
    class TCylinder:TCircle
    {
        private double h;
        public double H
        {
            get { return h; }
            set
            {
                if (value < 0)
                    throw new Exception("Side must be positive number");
                H = value;
            }
        }
        public TCylinder(double r, double h) : base(r)
        {
            H = h;
        }
        public override string ToString()
        {
            return $"{R},{h}";
        }
        new public double Square()
        {
            double S = base.Length() * h + base.Square();
            return S;  
        }
        public double Volume()
        {
           return  base.Square() * h;
        }
        public static TCylinder operator +(TCylinder c1, TCylinder c2)
        {
            return new TCylinder(c1.R + c2.R,c1.H+c2.H);
        }
        public static TCylinder operator -(TCylinder c1, TCylinder c2)
        {
            return new TCylinder(c1.R - c2.R, c1.H - c2.H);
        }
        public static TCylinder operator *(TCylinder c, double number)
        {
            return new TCylinder(c.R * number,c.H * number);
        }



    }
}
