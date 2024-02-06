using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vectors
            Vector V1 = new Vector(1, 2, 3);
            Vector V2 = new Vector(-1, 4, -5);

            // TODO: add inputting vectors, with comma separating inputs

            // Tests
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("V1: " + V1);
            Console.WriteLine("V2: " + V2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSubtract: " + (V1 - V2));
            Console.WriteLine("Negate V2: " + (-V2));
            Console.WriteLine("Add: " + (V1 + V2));
            Console.WriteLine("Multiply V2 by 4: " + (V2 * 4));
            Console.WriteLine("Divide V1 by 2: " + (V1 / 2));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEquals: " + (V1 == V2));
            Console.WriteLine("NOT Equals: " + (V1 != V2));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNormalize V1: " + V1.Normalize);
            Console.WriteLine("Direction of V2: " + V2.Direction);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nDot Product: " + Vector.DotProduct(V1, V2));
            Console.WriteLine("Cross Product: " + Vector.CrossProduct(V1, V2));
            Console.WriteLine("Angle Between (Rad): " + Vector.AngleBetween(V1, V2));
            Console.WriteLine("Angle Between (Deg): " + (Vector.AngleBetween(V1, V2) / MathF.PI) * 180);

            // Complete
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
