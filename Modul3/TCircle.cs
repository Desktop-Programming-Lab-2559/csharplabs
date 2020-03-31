using System;
using System.Collections.Generic;
using System.Text;

namespace Modul
{
    class TCircle
    {
        private double r;
        public double R
        {
            get { return r; }
            set
            {
                if (value < 0)

                    throw new Exception("radius must be positive");
                r = value;
            }
        }
        public TCircle(double userR)
        {
            R = userR;
        }
            
        public override string ToString()
        {
            return $"{R}";
        }
        public TCircle(TCircle b)
        {
            this.r = b.r;
        }
        public double Square()
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        public double Length()
        {
            return 2 *r* Math.PI ;
        }
        /*public static bool operator ==(TCircle r1, TCircle r2)
        {
            return r1.R == r2.R ;
        }

        public static bool operator !=(TCircle r1, TCircle r2)
        {
            return !(r1 == r2);
        }*/
        public static TCircle operator +(TCircle c1, TCircle c2)
        {
            return new TCircle(c1.r + c2.r);
        }
        public static TCircle operator -(TCircle c1, TCircle c2)
        {
            return new TCircle(c1.r - c2.r);
        }
        public static TCircle operator *(TCircle circle, double number)
        {
            return new TCircle(circle.r * number);
        }
        

    }
}
