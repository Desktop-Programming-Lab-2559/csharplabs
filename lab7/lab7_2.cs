using System;

namespace lab7_2
{
    class Program
    {
        static int Sum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }
        static int Product(int number)
        {
            int product = 1;
            for (int i = 1; i <= number; i++)
            {
                product *= i;
            }
            return product;
        }
        static void Main(string[] args)
        {
            
            Console.Write("count of rows = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("count of cols = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m]; 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i * j % 2 != 0)
                    {
                        matrix[i, j] = Sum(i);
                    }
                    if (i * j % 2 == 0)
                    {
                        matrix[i, j] = Product(j);
                    }
                   
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i,j] + " "); 
                }
                Console.WriteLine();
            }

        }
    }
}
