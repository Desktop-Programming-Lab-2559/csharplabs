using System;

namespace lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.Write("n=");				
            n = int.Parse(Console.ReadLine());

            double[] a = new double[n];		
            {
                Console.Write("a[{0}]=", i);
                a[i] = double.Parse(Console.ReadLine());
            }

            double[] b = new double[n];		
            for (int i = 0; i < n; i++)		
            {
                Console.Write("b[{0}]=", i);
                b[i] = double.Parse(Console.ReadLine());
            }

            double[] c = new double[n]; 		
            for (int i = 0; i < n; i++)		
            {
                c[i] = a[i] + b[i];
            }

            for (int i = 0; i < n; i++)		
            {
                Console.WriteLine("c[{0}]={1}", i, c[i]);
            }

            Console.ReadLine();
        }

    }
}

