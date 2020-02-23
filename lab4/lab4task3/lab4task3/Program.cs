using System;

namespace lab4task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.Write("x1 = ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("x2 = ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y1 = ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y2 = ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("z1 = ");
                double z1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("z2 = ");
                double z2 = Convert.ToDouble(Console.ReadLine());
                double a = Math.Sqrt(Math.Pow((z1 - x1), 2) + Math.Pow((y2 - x2), 2));
                double b = Math.Sqrt(Math.Pow((z1 - y1), 2) + Math.Pow((z2 - y2), 2));
                double c = Math.Sqrt(Math.Pow((z1 - x1), 2) + Math.Pow((z2 - x2), 2));
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.Write("epsilon = ");
                double eps = Convert.ToDouble(Console.ReadLine());
                if (s < eps)
                    Console.WriteLine("a degenerate triangle");
                else
                    Console.WriteLine("not a degenerate triangle");



            }
        }
}
