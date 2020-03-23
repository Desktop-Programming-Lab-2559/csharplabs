using System;

namespace lab11_1
{
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
}
