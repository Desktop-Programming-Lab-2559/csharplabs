# Лабораторна робота 6
## Варіант 1
## Завдання 1
Дано n  дійсних чисел:x1, x2,..., xn . Знайти середнє арифметичне значення цих чисел.
```cs 
static void Main(string[] args) 
        {
            Console.Write("n = ");
            int count = Convert.ToInt32(Console.ReadLine());
            double[] num = new double[count];
            double sum = 0;
            double average;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToDouble(Console.ReadLine());
                sum += num[i];
            }
            average = sum / num.Length;
            Console.WriteLine(average);
        }
```
## Завдання 2
Побудувати масив А=(ai), елементи якого задаються формулою:
a1 = a2 = x, a3 = y, ai = ai-2 + ai-1/2^i-1*ai-3,  (i = 4,5...,n)
де x, y – вводяться з клавіатури. Вивести кількість елементів масиву А, які більші за задане число z.

```cs 
static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double ai = 0;
            double ai_2 = x;
            double ai_3 = x;
            double ai_1 = y;
            double[] arr = new double[n];
            for (int i = 4; i <= n; i++)
            {

                ai = ai_2 + (ai_1 / Math.Pow(2, (i - 1)) * ai_3);
                ai_3 = ai_2;
                ai_2 = ai_1;
                ai_1 = ai;
                Console.WriteLine("arr[{0}] = {1:f2}",i,ai);
            }

```
## Завдання 3
Дано два вектори x, y Є *R*^n . Знайти суму векторів.
```cs 
static void Main(string[] args)
        {

            int n;
            Console.Write("n=");				
            n = int.Parse(Console.ReadLine());

            double[] a = new double[n];		
            {
                Console.Write("a[{0}]=", i);
                a[i] = double.Parse(Console.ReadLine());
            }

            double[] b = new double[n];		
            for (int i = 0; i < n; i++)		
            {
                Console.Write("b[{0}]=", i);
                b[i] = double.Parse(Console.ReadLine());
            }

            double[] c = new double[n]; 		
            for (int i = 0; i < n; i++)		
            {
                c[i] = a[i] + b[i];
            }

            for (int i = 0; i < n; i++)		
            {
                Console.WriteLine("c[{0}]={1}", i, c[i]);
            }

            Console.ReadLine();
        }

```
## Завдання 4
1.	Впорядкувати елементи масиву за зростанням.
```cs 
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
```