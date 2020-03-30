using System;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Prism p1;

            Prism3 p3 = new Prism3(6, 8);
            p1 = p3;
            double prmtr1 = p1.Volume();
            Console.WriteLine(prmtr1);
            double square1 = p1.Area();
            Console.WriteLine(square1);
            Prism4 p4 = new Prism4(12, 8);

            p1 = p4;
            double prmtr2 = p1.Volume();
            Console.WriteLine(prmtr2);
            double square2 = p1.Area();
            Console.WriteLine(square2);


            try
            {
                Console.Write("count of figures  = ");
                int m = Convert.ToInt32(Console.ReadLine());

                Prism[] objects = new Prism[m];
                Prism[] objects2 = new Prism[m];
                Random rnd = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < m; i++)
                {
                    objects[i] = new Prism3(rnd.Next(1, 10), rnd.Next(1, 10));
                    objects2[i] = new Prism4(rnd.Next(1, 10), rnd.Next(1, 10));
                }
                for (int i = 0; i < objects.Length; i++)
                {
                    Console.WriteLine(objects[i]);
                }
                double sumvol = 0;
                for (int i = 0; i < m; i++)
                {
                    sumvol += objects[i].Volume();
                }
                double sum = 0;
                for (int i = 0; i < m; i++)
                {
                    sum += objects2[i].Area();
                }
                Console.WriteLine($"sum of volumes = {sumvol}");
                Console.WriteLine($"sum of areas = {sum}");
            }
            catch
            {
                Console.WriteLine("Cannot be negative");
            }


        }
    }
}
