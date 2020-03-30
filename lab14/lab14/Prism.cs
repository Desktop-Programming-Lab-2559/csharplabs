using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    public abstract class Prism
    {
        private protected double data;
        public double Data
        {
            get { return data; }
            set
            {
                if (value < 0)
                    throw new Exception("Cannot be negative");
                data = value;
            }
        }
        private protected double data2;
        public double Data2
        {
            get { return data2; }
            set
            {
                if (value < 0)
                    throw new Exception("Cannot be negative");
                data2 = value;
            }
        }
        public Prism(double data, double data2)
        {
            Data = data;
            Data2 = data2;
        }

        public abstract double Area();

        public abstract double Volume();




    }
}
