# Лабораторна робота 7    
## Варіант 1
## Завдання 1

Дана цілочислова прямокутна матриця. 
Визначити суму від’ємних елементів матриці з обома парними індексами.
```cs
 static void Main(string[] args)
        {
            double sum = 0;
            Console.Write("size of matrix = ");
            int n = Convert.ToInt16(Console.ReadLine());
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0}][{1}]",i,j);
                    matrix[i,j] = Convert.ToDouble(Console.ReadLine());
                }
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0 && i % 2 == 0 && j % 2 == 0)
                        sum += matrix[i, j];
                }

            }
            Console.WriteLine("sum{0}",sum);
        }
```
## Завдання 2
Побудувати матрицю А, елементи якої задаються формулою:
 a_ij = 1 * 2 * 3...* j, якщо i * j - парне, інакше 1 + 2 + 3...+ i, де i = 1 до n, j = 1 до m.
Побудувати одновимірний масив (переписати матрицю в одновимірний масив).

```cs
class Program
    {
        static int Sum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }
        static int Product(int number)
        {
            int product = 1;
            for (int i = 1; i <= number; i++)
            {
                product *= i;
            }
            return product;
        }
        static void Main(string[] args)
        {
            
            Console.Write("count of rows = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("count of cols = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m]; 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i * j % 2 != 0)
                    {
                        matrix[i, j] = Sum(i);
                    }
                    if (i * j % 2 == 0)
                    {
                        matrix[i, j] = Product(j);
                    }
                   
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i,j] + " "); 
                }
                Console.WriteLine();
            }

        }
    }
```
## Завдання 3
Створити програму, для знаходження детермінанта квадратної матриці *A*(2x2)
```cs
static void Main(string[] args)
        {
            double det = 0;
            double[,] matr = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("matrix[{0}][{1}] = ", i, j);
                    matr[i, j] = Convert.ToDouble(Console.ReadLine());
                }

            }
            det = matr[0, 0] * matr[1, 1] - (matr[0, 1] * matr[1, 0]);
            Console.WriteLine(det);
        }
```
## Завдання 4
Дана цілочислова квадратна матриця.
Розмістити елементи парних рядків у порядку зростання.

```cs
class Program
    {
        static void Main(string[] args)
        {
            double start = 0;
            
            Console.Write("size of matrix = ");
            int n = Convert.ToInt16(Console.ReadLine());
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.Write("matrix[{0}][{1}] = ",i, j);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }  
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for(int k = j + 1; k < n; k++) 
                    { 
                        if (i % 2 == 0)
                    {

                           if (matrix[i, j] > matrix[i, k])
                        {
                            start = matrix[i, j];
                            matrix[i, j] = matrix[i, k];

                            matrix[i, k] = start;
                         } 
                      }
                    }
                }


             }       
                    foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
```
## Завдання 5
Дана цілочислова прямокутна матриця. Визначити кількість рядків, які не містять жодного нульового елемента.
```cs
 class Program
    {
        static void Main(string[] args)
        {
            Console.Write("matrix size = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0}][{1}] = ",i,j);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
             
                } 
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool iszero = false;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        iszero = true;
                        break;
                    }
                    
                }
                if (iszero == true)
                    count++;
            }
            int res = n - count;
            Console.WriteLine($"count = {res}");
        }
    }
```
## Завдання 6
Дана цілочислова прямокутна матриця. Визначити максимальне із чисел, яке зустрічається в даній матриці більше одного разу.
```cs
 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matrix size = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matr = new double[n, n];
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0}][{1}] = ", i,j);
                    matr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                
            }
            double max = 0, count = 0;
            bool appear = false;
            do 
            { 
            for (int i =0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    max = matr[0, 0];
                    if (max < matr[i, j])
                        max = matr[i, j]; 
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matr[i, j] == max)
                        count++;
                }
            }
            if (count > 1) 
                appear = true;
            else
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (matr[i, j] == max)
                            matr[i, j] = int.MinValue;

               }
        while(!appear);
            Console.WriteLine(max);
        }
        
    }
```
