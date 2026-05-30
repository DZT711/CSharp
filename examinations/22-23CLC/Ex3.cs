using System;
namespace Examinations._22_23CLC
{    public class Ex3
    {   
        public class Vector
        {
            public double x;
            public double y;
            // a
            public Vector(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public Vector()
            {
                this.x = 0;
                this.y = 0;
            }
            // b
            ~Vector()
            {
                Console.WriteLine("Vector object is being destroyed.");
            }
            // c
            public static Vector PlusVectors(Vector v1, Vector v2)
            {
                return new Vector(v1.x + v2.x, v1.y + v2.y);
            }
            // Tích vô hướng
            public static int DotProduct(Vector v1, Vector v2)
            {
                return (int)(v1.x * v2.x + v1.y * v2.y);
            }
        } 
        public static void Main()
        {
            // d
            Vector v1 = new Vector(1, 2);
            Vector v2 = new Vector(3, 4);
            Vector v3 = Vector.PlusVectors(v1, v2);
            Console.WriteLine($"v3: ({v3.x}, {v3.y})");
            int dotProduct = Vector.DotProduct(v1, v2);
            Console.WriteLine($"Dot Product: {dotProduct}");
        }
    }
}