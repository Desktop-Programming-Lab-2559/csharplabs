using System;

namespace lab4task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (a == c && c == n && a == n)
                Console.WriteLine(Math.Cos((a + c + n) * Math.PI / 180));
            else if (a < c && c == n)
                Console.WriteLine(Math.Cos((a * c * n) * Math.PI / 180));
            else if (a < c && c < n)
                Console.WriteLine(Math.Cos(((a + c) * n) * Math.PI / 180));
            else
                Console.WriteLine("0");


        }
    }
}
