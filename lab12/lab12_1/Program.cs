using System;

namespace lab12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("first enter sum of money, the course of dollar");
            Money m1 = new Money(2500, 27);
            Console.Write("enter second sum= ");
            double sum2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(m1.Add_Money(sum2));
            Console.WriteLine(m1.Course());
            Console.WriteLine(m1.Withdrawal_Money(sum2));
            

        }
            
               
        }
    }

