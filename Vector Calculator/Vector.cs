using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Non-Static Functions

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
            return MathF.Sqrt((x * x) + (y * y) + (z * z));
        }

        public float GetDirection()
        {
            return MathF.Atan(y / x);
        }

        // Operators

        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector operator-(Vector v1, Vector v2)
        {
            return v1 + Vector.Negate(v2);
        }

        public static bool operator==(Vector v1, Vector v2)
        {
            return (v1.x == v2.x) && (v1.y == v2.y) && (v1.z == v2.z);
        }
        public static bool operator!=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        public static Vector operator*(Vector v, float scale)
        {
            return new Vector(v.x * scale, v.y * scale, v.z * scale);
        }
        public static Vector operator*(Vector v1, Vector v2)
        {
            return new Vector(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
        }

        public static Vector operator/(Vector v, float scale)
        {
            return new Vector(v.x / scale, v.y / scale, v.z / scale);
        }
        public static Vector operator/(Vector v1, Vector v2)
        {
            return new Vector(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z);
        }

        // Static Functions

        public static Vector Negate(Vector v)
        {
            return new Vector(-v.x, -v.y, -v.z);
        }

        public static Vector Normalize(Vector v)
        {
            float Magnitude = v.GetMagnitude();
            return new Vector(v.x / Magnitude, v.y / Magnitude, v.z / Magnitude);
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            return MathF.Acos(Vector.DotProduct(v1, v2) / (v1.GetMagnitude() * v2.GetMagnitude()));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }
    }
}
