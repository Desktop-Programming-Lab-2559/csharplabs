using System;

namespace lab5task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
                a *= (a + 1);
            Console.WriteLine($"example = {a}");
        }
    }
}
