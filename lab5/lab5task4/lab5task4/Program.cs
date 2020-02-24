using System;

namespace lab5task4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("n = 10 ");
            int n  = Convert.ToInt32(Console.ReadLine());
            
            double x0 = 1;
            double xi = 10;
            for (int i = 1; i <= n; i++)
            { 
                xi = x0 + i * 2;
                x0 = xi;
            }
             Console.WriteLine("xi = {0}", xi);


        }
    }
}
