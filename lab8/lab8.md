# Лабораторна робота 8   
## Варіант 1
## Завдання 1
За даними дійсними числами a і b  обчислити
 u = f(a,b)+f(2,a)+2,де
  `f(x,y) = {
      x^3+sqrt(x^2+x^4),x>y,
      (x^2 - 2x + sqrt(x))/sqrt(x^3,5), інакше
  }`


```cs
namespace lab8_1
{
    class Program
    {   static double EvalFunc(double x, double y)
        {
            if (x > y)
            {
                
                return Math.Pow(x, 3) + Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 4));
            }
            else
            {
                return (Math.Pow(x, 2) - 2 * x + Math.Pow(x, 1.0 / 2)) / Math.Pow(x, 3.0 / 5);
            }
        }     
              
        static void Main(string[] args)
        {
            Console.Write("enter a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double u = EvalFunc(a, b) + EvalFunc(2, b) + 2;
            Console.WriteLine(u);
        }
    }
}

```
## Завдання 2
Використовуючи підпрограму для знаходження скалярного добутку, обчислити значення виразу s=2<a,b>-3<a,c>, де a,b,c , <x,y> –  скалярний добуток векторів. 
```cs
namespace lab8_2
{
    class Program
    {
        static double ScalProd(double[] coords_x, double[] coords_y)
        {
            double product = 1;
            double sum = 0;
            for (int i = 0; i < coords_x.Length; i++)
            {
                product = coords_x[i] * coords_y[i];
                sum += product;
            }
            return sum;
        }
        static double[] Mult(double[] coords_x, double[] coords_y)
        {
            double[] multvec = new double[coords_x.Length];
            for (int i = 0; i < coords_x.Length; i++)
                multvec[i] = coords_x[i] * coords_y[i];
            return multvec;
        }
        static void Main(string[] args)
        {
            Console.Write("size of vectors = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("vector a coord[{0}] = ", i);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("vector a coord[{0}] = ", i);
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("vector a coord[{0}] = ", i);
                c[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            double res = 2 * ScalProd(a, b) - 3 * ScalProd(a, c);
            Console.WriteLine($"scslar poduct of vectors = {res}");
            double[] res2 = Mult(a, b);
            for(int i  = 0; i < n; i++)
            Console.Write(res2[i]+",");
            
        }

    }

}
```
## Завдання 3
Використовуючи підпрограму для знаходження n-тового числа Фібоначчі. Обчислити значення виразу s = *f3*+*f8*, де  – *fi*- i -тове число Фібоначчі
```cs
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

```