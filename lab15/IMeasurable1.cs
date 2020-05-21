using System;
using System.Collections.Generic;
using System.Text;

namespace lab15
{
    interface IMeasurable1
    {
        double X1 { get; set; }
        double X2 { get; set; }
        double X3 { get; set; }
        double X4 { get; set; }
        double Y1 { get; set; }
        double Y2 { get; set; }
        double Y3 { get; set; }
        double Y4 { get; set; }
        double Perimeter();
        double Square();
        string Type();
    }
}
