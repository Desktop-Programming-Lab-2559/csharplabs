# Лабораторна робота №4
## Завдання 1
Трикутник задається координатами своїх вершин на площині: __A(x1, y1), B(x2, y2), C(x3, y3)__. Cкласти програму для знаходження площі трикутника за формулою Герона.
```cs
Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z1 = ");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z2 = ");
            double z2 = Convert.ToDouble(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow((z1 - x1), 2) + Math.Pow((y2 - x2), 2));
            double b = Math.Sqrt(Math.Pow((z1 - y1), 2) + Math.Pow((z2 - y2), 2));
            double c = Math.Sqrt(Math.Pow((z1 - x1), 2) + Math.Pow((z2 - x2), 2));
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Square = {s}");
```
## Завдання 2
Дано 2 дійсних числа: __a,b__. З'ясувати, чи належать ці числа інтервалу __[1,2] ∪ (3,7)__.
```cs
Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a <= 2 && a >= 1 || a < 7 && a > 3)
            {
                if (b <= 2 && b >= 1 || b < 7 && b > 3)
                {
                    Console.WriteLine("Yes");
                }
            }
            else
                Console.WriteLine("No");
```
## Завдання 3
Трикутник задається координатами своїх вершин на площині: __A(x1, y1), B(x2, y2), C(x3, y3)__. Визначити, чи є цей трикутник виродженим.
```cs
Console.Write("x1 = ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("x2 = ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y1 = ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y2 = ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("z1 = ");
                double z1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("z2 = ");
                double z2 = Convert.ToDouble(Console.ReadLine());
                double a = Math.Sqrt(Math.Pow((z1 - x1), 2) + Math.Pow((y2 - x2), 2));
                double b = Math.Sqrt(Math.Pow((z1 - y1), 2) + Math.Pow((z2 - y2), 2));
                double c = Math.Sqrt(Math.Pow((z1 - x1), 2) + Math.Pow((z2 - x2), 2));
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.Write("epsilon = ");
                double eps = Convert.ToDouble(Console.ReadLine());
                if (s < eps)
                    Console.WriteLine("a degenerate triangle");
                else
                    Console.WriteLine("not a degenerate triangle");
```
## Завдання 4
Знайти значення __y__.
```py
y = {
    cos(A + C + N), якщо A = C = N,
    cos(A * C * N), якщо A < C = N,
    cos((A + C) * N), якщо A < C < N,
    0, у інших випадках
}
```
```cs
 Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (a == c && c == n && a == n)
                Console.WriteLine(Math.Cos((a + c + n) * Math.PI / 180));
            else if (a < c && c == n)
                Console.WriteLine(Math.Cos((a * c * n) * Math.PI / 180));
            else if (a < c && c < n)
                Console.WriteLine(Math.Cos(((a + c) * n) * Math.PI / 180));
            else
                Console.WriteLine("0");
```