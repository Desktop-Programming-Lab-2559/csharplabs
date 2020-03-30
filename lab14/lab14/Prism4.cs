using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class Prism4 : Prism
    {
        public Prism4(double a, double h) : base(a, h) { }

        public override double Area()
        {
            double Sb = 4 * Data * Data2;
            double So = Data * Data;
            double S = Sb + 2 * So;
            return S;
        }

        public override double Volume()
        {
            return Data * Data * Data2;
        }

        public override string ToString()
        {
            return $"Prism4: Sides = {Data}, {Data2}";
        }


    }
}
