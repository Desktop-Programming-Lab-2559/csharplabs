using System;

namespace lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double start = 0;
            
            Console.Write("size of matrix = ");
            int n = Convert.ToInt16(Console.ReadLine());
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.Write("matrix[{0}][{1}] = ",i, j);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }  
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for(int k = j + 1; k < n; k++) 
                    { 
                        if (i % 2 == 0)
                    {

                           if (matrix[i, j] > matrix[i, k])
                        {
                            start = matrix[i, j];
                            matrix[i, j] = matrix[i, k];

                            matrix[i, k] = start;
                         } 
                      }
                    }
                }


             }       
                    foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
