# Лабораторна робота №5
## Завдання 1
Дане дійсне число __a__ і натуральне число __n__. Обчислити __a(a+1)...(a+n-1)__.
```cs
Console.Write("a = ");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            double p = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
                p *= (a + i);
            Console.WriteLine($"example = {a}");
```
## Завдання 2
Дано __n ∈ ℕ__. Побудувати алгоритм для визначення кількості цифр у цьому числі.
```cs
Console.Write("enter the number, n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (n!=0)
            {
                n /= 10;
                count += 1;
            }
            Console.WriteLine($"count = {count}");
```
## Завдання 3
Перевірити справедливість рівності при заданій точності  Ɛ:
```py
ln(x) = 2 + [
    (x-1)/(x+1) + 1/3*(x-1/x+1)**3 +... + 1/(2*n-1)*(x-1/x+1)**2*n-1+..
], x > 0
```
```cs
Console.Write("enter the epsilon = ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double sum = 2;
            double f = 1;
            int n = 1;
            while (true)
            {
                double result = Math.Abs((1 / f) * Math.Pow((x - 1) /( x + 1) ,(2 * n - 1)));
                if(result >= e)
                {
                    sum += result;
                    n += 1;
                    f *= (2 * n - 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("result = {0}",sum);
```
## Завдання 4
Нехай __х0 = 1, хі = х(і-1)+ 2і__, де __і = 1,2,...__.Визначити __х10__.
```cs
     
            double x0 = 1;
            double xi = 0;
            
            for (int i = 1; i <= 10; i++)
            { 
                xi = x0 + i * 2;
                x0 = xi;
            }
             Console.WriteLine("xi = {0}", xi);
```
