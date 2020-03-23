# Лабораторна робота №11
## Завдання
Описати клас, який містить вказані поля і методи.
| **Клас** Вектора R^2 - Vector2D                       ||    
| ----------------|--------------------------:                                                                             |
|   **поля**      |для зберігання координат вектора                                                                        |
|   **методи**    |конструктор без параметрів,конструктор з параметрами,   конструктор копіювання                          |
|                 |введення/виведення елементів вектора                                                                    |
|                 |визначення довжини вектора                                                                              |
|                 |порівняння з іншим вектором                                                                             |
|                 |перевантаження операторів +(додавання векторів),-(віднімання векторів),*(знаходження скалярного добутку)|
__Program.cs__
```cs
class Program
    {
        static void Main(string[] args)
        {
        
            Vector2D v1 = new Vector2D(3, 5);
            Vector2D v2 = new Vector2D(1, 3);
            Console.WriteLine($"Length = {v1.Length()} ");
            Console.WriteLine($"Normalize vector = {v1.Normalize()} ");
            Console.WriteLine($"Vetor with coords {v2} is equal to {v1}: {v1.Comparing(v2.X, v2.Y)}");
            Vector2D v3 = v1 + v2;
            Console.WriteLine($"Sum {v1}+{v2} = {v3}");
            Vector2D v4 = v1 - v2;
            Console.WriteLine($"Diff {v1}-{v2} = {v4}");
            double v5 = v1 * v2;
            Console.WriteLine($"Scalar product {v1}*{v2} = {v5}");


        }
    }
```
__Vector2D.cs__
```cs
class Vector2D
    {
        public double X { set; get; }
        public double Y { set; get; }
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";

        }
        public Vector2D(Vector2D previousVector2D)
        {
            X = previousVector2D.X;
            Y = previousVector2D.Y;
        }
        public double Length()
        {
            return Math.Sqrt(X*X + Y*Y);
        }
        public  Vector2D Normalize()
        { 
            double length = Math.Sqrt(X * X + Y * Y);
            if (length == 0) return new Vector2D(0, 0);
            else return new Vector2D(X / length, Y / length);
        }
        
        public bool Comparing(double userX,double userY)
        {
            if (X == userX && Y == userY) return true;
            else return false;
        
        }
        public static  Vector2D operator +(Vector2D v1,Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X,v1.Y+v2.Y);
        }
        public static Vector2D operator -(Vector2D c1, Vector2D c2)
        {
            return new Vector2D(c1.X - c2.X, c1.Y - c2.Y);
        }
        public static double operator *(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }
    }
}

```