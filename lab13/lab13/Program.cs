using System;

namespace lab13
{
    class Program
    {
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
}
