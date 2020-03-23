using System;

namespace lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.Write("size of matrix = ");
            int n = Convert.ToInt16(Console.ReadLine());
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0}][{1}]",i,j);
                    matrix[i,j] = Convert.ToDouble(Console.ReadLine());
                }
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0 && i % 2 == 0 && j % 2 == 0)
                        sum += matrix[i, j];
                }

            }
            Console.WriteLine("sum{0}",sum);
        }
    }
}
