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
            double ai_2 = x;
            double ai_3 = x;
            double ai_1 = y;
            double[] arr = new double[n];
            for (int i = 4; i <= n; i++)
            {

                ai = ai_2 + (ai_1 / Math.Pow(2, (i - 1)) * ai_3);
                ai_3 = ai_2;
                ai_2 = ai_1;
                ai_1 = ai;
                Console.WriteLine("arr[{0}] = {1:f2}",i,ai);
            }

        }
        
    }
}

