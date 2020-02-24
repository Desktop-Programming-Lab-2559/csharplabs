using System;

namespace lab5task4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("n = 10 ");
            //int n  = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            double x0 = 1;
            while (i <= 10)
            {
                double xi;
                xi = x0 + 1 * 2; 
                x0 = xi;
                i += 1;
                Console.WriteLine("xi = {0}", xi);
            
            }
            


        }
    }
}
