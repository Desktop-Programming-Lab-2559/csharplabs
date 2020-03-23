using System;

namespace lab8_3
{
    class Program
    {
        static int Fib(int num)
        {
            return num == 1 || num == 2 ? 1 : Fib(num - 1) + Fib(num - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("'i' Fibonacci number, i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("'j' Fibonacci number, j = ");
            int j = Convert.ToInt32(Console.ReadLine());
            int res = Fib(i) + Fib(j);
            Console.WriteLine($"Fib{i} + Fib{j} = {res}");

        }
    }
}
