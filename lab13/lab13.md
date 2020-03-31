# Лабораторна робота 14
 # Варіант 1
 ## Завдання 1
 
| **Клас** Вектора R^2 - Vector2D                       ||    
| ----------------|--------------------------:                                                                             |
|   **поля**      |для зберігання координат вектора                                                                        |
|   **методи**    |конструктор без параметрів,конструктор з параметрами,   конструктор копіювання                          |
|                 |введення/виведення елементів вектора                                                                    |
|                 |визначення довжини вектора                                                                              |
|                 |порівняння з іншим вектором                                                                             |
|                 |перевантаження операторів +(додавання векторів),-(віднімання векторів),*(знаходження скалярного добутку)|
--------------------------------------------------------------------------------------------------------------------------:
| Створити клас-нащадок TVector3D (вектор у  ) на основі класу TVector2D. Додати третю координату вектора та перевизначити відповідні методи.|
| Створити програму-клієнт для тестування.|

__Program.cs__
```cs 
static void Main(string[] args)
        {
            try
            {
                Vector2D v1 = new Vector2D(6, 9);
                Vector2D v2 = new Vector2D(15, 34);
                Console.WriteLine($"V1: {v1}");
                Console.WriteLine($"V2: {v2}");
                Console.WriteLine($"Length of V1 = {v1.Length()}");
                Console.WriteLine($"Normalise V1 = {v1.Normalize()}");

                Console.WriteLine($"V1 = V2: { v1 == v2}");
                Console.WriteLine($"V1 + V2: {v1 + v2}");
                Console.WriteLine($"V2-V1: {v2 - v1}");
                Console.WriteLine($"Scalar V1 * V2: {v1 * v2}");
                Console.WriteLine("\n");

                TVector3D v3 = new TVector3D(6, 9, 5);
                TVector3D v4 = new TVector3D(2, 8, 3);
                Console.WriteLine($"V3: {v3}");
                Console.WriteLine($"V4: {v4}");
                Console.WriteLine($"Length of V3 = {v3.Length()}");
                Console.WriteLine($"Normalise V3 = {v3.Normalize()}");

            }
            catch
            {
                Console.WriteLine("coords of vector must be nonegative");
            }

        }
    }
```
__Vector2D.cs__
```cs
 class Vector2D
    {
        public double X { set; get; }
        public double Y { set; get; }
        private const double EPSILON = 0.001;
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
            return Math.Sqrt(X * X + Y * Y);
        }
        public Vector2D Normalize()
        {
            double length = Length();
            if (length == 0) return new Vector2D(0, 0);
            else return new Vector2D(X / length, Y / length);
        }

        public static bool operator ==(Vector2D v, Vector2D v1)
        {
            return (Math.Abs(v.X - v1.X) < EPSILON && Math.Abs(v.Y - v1.Y) < EPSILON);
        }
        public static bool operator !=(Vector2D v, Vector2D v1)
        {
            return !(v == v1);
        }
        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
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
```
__TVector3D__
```cs
class TVector3D : Vector2D
    {
        public double Z { set; get; }
        private const double EPSILON = 0.001;
        public TVector3D(double X, double Y, double z) : base(X, Y)
        {
            Z = z;
        }
        new public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        new public Vector2D Normalize()
        {
            double length = Length();
            if (length == 0) return new TVector3D(0, 0, 0);
            else return new TVector3D(X / length, Y / length, Z / length);
        }
        public static bool operator ==(TVector3D v, TVector3D v1)
        {
            return (Math.Abs(v.X - v1.X) < EPSILON && Math.Abs(v.Y - v1.Y) < EPSILON && Math.Abs(v.Z - v1.Z) < EPSILON);
        }

        public static bool operator !=(TVector3D v, TVector3D v1)
        {
            return !(v == v1);
        }
        public static TVector3D operator +(TVector3D v1, TVector3D v2)
        {
            return new TVector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static TVector3D operator -(TVector3D v1, TVector3D v2)
        {
            return new TVector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
        public static double operator *(TVector3D v1, TVector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";

        }
    }
```