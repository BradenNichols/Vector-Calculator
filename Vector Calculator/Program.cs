using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input Vectors

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please input a vector.");

            string[] input1 = ((string)Console.ReadLine()).Split(",");

            Console.WriteLine("Please input another vector.");

            string[] input2 = ((string)Console.ReadLine()).Split(",");

            Vector V1 = new Vector(Convert.ToSingle(input1[0]), Convert.ToSingle(input1[1]), Convert.ToSingle(input1[2]));
            Vector V2 = new Vector(Convert.ToSingle(input2[0]), Convert.ToSingle(input2[1]), Convert.ToSingle(input2[2]));
            
            // Tests

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nV1: " + V1);
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
            Console.WriteLine("Project V1 onto V2: " + Vector.ProjectOnto(V1, V2));

            // Complete
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
