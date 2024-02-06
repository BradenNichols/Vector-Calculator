using System;

namespace Vector_Calculator
{
    public struct Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        //public float[] components;

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
        public override bool Equals(object obj)
        {
            if (!(obj is Vector))
                return false;

            return this == (Vector) obj;
        }

        public float Magnitude => MathF.Sqrt((x * x) + (y * y) + (z * z));
        public float Direction => MathF.Atan(y / x);
        public Vector Normalize => this / Magnitude;

        // Operators

        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        
        public static Vector operator-(Vector v1, Vector v2) => v1 + Vector.Negate(v2);
        public static Vector operator-(Vector v1) => Vector.Negate(v1);

        public static bool operator==(Vector v1, Vector v2)
        {
            return (v1.x == v2.x) && (v1.y == v2.y) && (v1.z == v2.z);
        }
        public static bool operator!=(Vector v1, Vector v2) => !(v1 == v2);

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

        public static Vector Negate(Vector v) => new Vector(-v.x, -v.y, -v.z);

        public static float DotProduct(Vector v1, Vector v2)
        {
            return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            float x = (v1.y * v2.z) - (v1.z * v2.y);
            float y = (v1.z * v2.x) - (v1.x * v2.z);
            float z = (v1.x * v2.y) - (v1.y * v2.x);
            return new Vector(x, y, z);
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            return MathF.Acos(Vector.DotProduct(v1, v2) / (v1.Magnitude * v2.Magnitude));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }
    }
}
