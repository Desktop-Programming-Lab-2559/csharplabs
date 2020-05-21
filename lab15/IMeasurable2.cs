using System;
using System.Collections.Generic;
using System.Text;

namespace lab15
{
    interface IMeasurable2
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }
        double D { get; set; }
        double Perimeter();
        double Square();
        string Type();
    }
}
