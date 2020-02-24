using System;

namespace lab5task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number, n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (n!=0)
            {
                n /= 10;
                count += 1;
            }
            Console.WriteLine($"count = {count}");

        }
    }
}
