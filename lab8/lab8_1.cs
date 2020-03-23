using System;

namespace lab8_1
{
    class Program
    {   static double EvalFunc(double x, double y)
        {
            if (x > y)
            {
                
                return Math.Pow(x, 3) + Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 4));
            }
            else
            {
                return (Math.Pow(x, 2) - 2 * x + Math.Pow(x, 1.0 / 2)) / Math.Pow(x, 3.0 / 5);
            }
        }     
              
        static void Main(string[] args)
        {
            Console.Write("enter a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double u = EvalFunc(a, b) + EvalFunc(2, b) + 2;
            Console.WriteLine(u);
        }
    }
}
