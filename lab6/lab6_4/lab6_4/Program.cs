using System;

namespace lab6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("array size =  ");
            int s = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[s];
            double e = 0;
            for(int i = 0; i<s; i++)
            {
                Console.Write("arr[{0}] = ",i);
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i <= s - 1; i++)
            {
                for (int j = i + 1; j < s; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        e = arr[i];
                        arr[i] = arr[j];
                        arr[j] = e;
                    }
                }
            }
            Console.WriteLine("sorted array");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }


}  
    

