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
            Console.Write("Prism3: enter the value of side  ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prism3: enter the value of height  ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prism4: enter the value of side  ");
            double v3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prism4: enter the value of height  ");
            double v4 = Convert.ToDouble(Console.ReadLine());



            try
            {
                Console.Write("count of figures  = ");
                int m = Convert.ToInt32(Console.ReadLine());

                Prism[] objects = new Prism[m];
                Prism[] objects2 = new Prism[m];
               
                for (int i = 0; i < m; i++)
                {
                    //do
                    {
                        for (double j = 0; j < 1000; j += 0.1)
                        {
                            objects[i] = new Prism3(v1 + j, v2 + j);
                            objects2[i] = new Prism4(v3 + j, v4 + j);
                        }
                    }
                   //while (objects[i + 1].Volume() - objects[i].Volume() ==0 && objects2[i + 1].Volume() - objects2[i].Volume() ==0);
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
