using System;

namespace Modul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tcirle");
            TCircle c1 = new TCircle(4);
            TCircle c2 = new TCircle(8);
            Console.WriteLine($"Length = {c1.Length()} ");
            Console.WriteLine($"Square = {c1.Square()} ");
           
            TCircle c3 = c1 + c2;
            Console.WriteLine($"Sum {c1}+{c2} = {c3}");
            TCircle c4 = c2 - c1;
            Console.WriteLine($"Diff {c1}-{c2} = {c4}");
            Console.Write("number = ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Mul :{c1 * number}");

            Console.WriteLine("TCylinder");
            TCylinder x1 = new TCylinder(4,7);
            TCylinder x2 = new TCylinder(8,12);
            Console.WriteLine($"Volume= {x1.Volume()} ");
            Console.WriteLine($"Square = {x1.Square()} ");

            TCylinder x3 = x1 + x2;
            Console.WriteLine($"Sum {x1}+{x2} = {x3}");
            TCylinder x4 = x1 - x2;
            Console.WriteLine($"Diff ({x1}-{x2} = {x4}");
            Console.WriteLine("number = ");
           
            Console.WriteLine($"Mul :{x1 * number}");

        }
    }
}
