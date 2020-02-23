using System;

namespace lab4task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a <= 2 && a >= 1 || a < 7 && a > 3)
            {
                if (b <= 2 && b >= 1 || b < 7 && b > 3)
                {
                    Console.WriteLine("Yes");
                }
            }
            else
                Console.WriteLine("No");
        }


    }
}
