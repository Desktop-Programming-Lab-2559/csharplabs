using System;

namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how you want to construct a quad? Write 'coords' or  'side' : ");
            string choose = Console.ReadLine();
            if (choose == "coords")
            {
                Coords c = new Coords(3, 5, 8, 9, 12, 32, 5, 6);
                Console.WriteLine((c as IMeasurable1).Perimeter());
                Console.WriteLine((c as IMeasurable1).Square());
                Console.WriteLine((c as IMeasurable1).Type());

            }
            else
            {
                try
                {
                    Side s = new Side(12, 23, 12, 23);
                    Console.WriteLine((s as IMeasurable2).Perimeter());
                    Console.WriteLine((s as IMeasurable2).Square());
                    Console.WriteLine((s as IMeasurable2).Type());
                }
                catch { throw new Exception("side cannot be negative"); }
            }
        }
    }
}
