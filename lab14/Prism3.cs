using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class Prism3 : Prism
    {
        public Prism3(double a, double h) : base(a, h) { }

        public override double Area()
        {
            double Sb = 3 * Data * Data2;
            double So = Data * Data * Math.Pow(3, 1.0 / 2) / 4;
            double S = Sb + 2 * So;
            return S;
        }

        public override double Volume()
        {
            double So = Math.Pow(Data, 2) * Math.Pow(3, 1.0 / 2) / 4;
            double V = So * Data2;
            return V;
        }

        public override string ToString()
        {
            return $"Prism3: Sides = {Data}, {Data2}";
        }

    }
}
