using System;

namespace lab7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("matrix size = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0}][{1}] = ",i,j);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
             
                } 
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool iszero = false;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        iszero = true;
                        break;
                    }
                    
                }
                if (iszero == true)
                    count++;
            }
            int res = n - count;
            Console.WriteLine($"count = {res}");
        }
    }
}
