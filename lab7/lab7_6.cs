using System;

namespace lab7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matrix size = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matr = new double[n, n];
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0}][{1}] = ", i,j);
                    matr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                
            }
            double max = 0, count = 0;
            bool appear = false;
            do 
            { 
            for (int i =0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    max = matr[0, 0];
                    if (max < matr[i, j])
                        max = matr[i, j]; 
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matr[i, j] == max)
                        count++;
                }
            }
            if (count > 1) 
                appear = true;
            else
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (matr[i, j] == max)
                            matr[i, j] = int.MinValue;

               }
        while(!appear);
            Console.WriteLine(max);
        }
        
    }
}
