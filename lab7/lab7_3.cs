using System;

namespace lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double det = 0;
            double[,] matr = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("matrix[{0}][{1}] = ", i, j);
                    matr[i, j] = Convert.ToDouble(Console.ReadLine());
                }

            }
            det = matr[0, 0] * matr[1, 1] - (matr[0, 1] * matr[1, 0]);
            Console.WriteLine(det);
        }
    }
}
