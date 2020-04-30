using System;

namespace lab12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array a = new Array(12, 78.8, 23, 56, 34);
            Console.WriteLine(a[1]);
            Console.WriteLine(a);
            Console.WriteLine(a.Min());
            Console.WriteLine(a.Max());
        }
    }
}
