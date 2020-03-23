using System;

namespace lab8_2
{
    class Program
    {
        static double ScalProd(double[] coords_x, double[] coords_y)
        {
            double product = 1;
            double sum = 0;
            for (int i = 0; i < coords_x.Length; i++)
            {
                product = coords_x[i] * coords_y[i];
                sum += product;
            }
            return sum;
        }
        static double[] Mult(double[] coords_x, double[] coords_y)
        {
            double[] multvec = new double[coords_x.Length];
            for (int i = 0; i < coords_x.Length; i++)
                multvec[i] = coords_x[i] * coords_y[i];
            return multvec;
        }
        static void Main(string[] args)
        {
            Console.Write("size of vectors = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("vector a coord[{0}] = ", i);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("vector a coord[{0}] = ", i);
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("vector a coord[{0}] = ", i);
                c[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            double res = 2 * ScalProd(a, b) - 3 * ScalProd(a, c);
            Console.WriteLine($"scslar poduct of vectors = {res}");
            double[] res2 = Mult(a, b);
            for(int i  = 0; i < n; i++)
            Console.Write(res2[i]+",");
            
        }

    }

}

