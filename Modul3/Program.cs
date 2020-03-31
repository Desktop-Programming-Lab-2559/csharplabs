using System;

namespace Modul
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Tcirle");
                TCircle c1 = new TCircle(4);
                TCircle c2 = new TCircle(8);
                Console.WriteLine($"Length = {c1.Length()} ");
                Console.WriteLine($"Square = {c1.Square()} ");
                if (c1 == c2)
                    Console.WriteLine("Equal");
                else
                    Console.WriteLine("Not equal");

                TCircle c3 = c1 + c2;
                Console.WriteLine($"Sum {c1}+{c2} = {c3}");
                TCircle c4 = c2 - c1;
                Console.WriteLine($"Diff {c1}-{c2} = {c4}");
                Console.Write("number = ");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Mul :{c1 * number}");

                Console.WriteLine("TCylinder");
                TCylinder x1 = new TCylinder(4, 7);
                TCylinder x2 = new TCylinder(8, 12);
                Console.WriteLine($"Volume= {x1.Volume()} ");
                Console.WriteLine($"Square = {x1.Square()} ");

                TCylinder x3 = x1 + x2;
                Console.WriteLine($"Sum {x1}+{x2} = {x3}");
                TCylinder x4 = x2 - x1;
                Console.WriteLine($"Diff ({x2}-{x1} = {x4}");

                Console.WriteLine($"Mul :{x1 * number}");
            }
            catch
            {
                Console.WriteLine("Side of cylinder must be positive.");
            }
        }
    }
}
