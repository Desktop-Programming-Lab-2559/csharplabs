using System;

namespace lab5task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the epsilon = ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double sum = 2;
            double f = 1;
            int n = 1;
            while (true)
            {
                double result = Math.Abs((1 / f) * Math.Pow((x - 1) /( x + 1) ,(2 * n - 1)));
                if(result >= e)
                {
                    sum += result;
                    n += 1;
                    f *= (2 * n - 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("result = {0}",sum);
        }
    }
}
