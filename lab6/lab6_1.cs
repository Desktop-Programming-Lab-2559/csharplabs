using System;

namespace lab6_1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("n = ");
            int count = Convert.ToInt32(Console.ReadLine());
            double[] num = new double[count];
            double sum = 0;
            double average;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToDouble(Console.ReadLine());
                sum += num[i];
            }
            average = sum / num.Length;
            Console.WriteLine(average);
        }
    }
}
