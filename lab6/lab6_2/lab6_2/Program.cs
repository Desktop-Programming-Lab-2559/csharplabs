using System;

namespace lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double ai = 0;
            double a1 = x;
            double a2 = x;
            double a3 = y;
            for (int i = 4; i <= n; i++)
            {

                ai = a2 + (a3 / Math.Pow(2, (i - 1)) * a1);
                a1 = a2;
                a2 = a3;
                a3 = ai;
                Console.WriteLine(ai);
            }

        }
        
    }
}

