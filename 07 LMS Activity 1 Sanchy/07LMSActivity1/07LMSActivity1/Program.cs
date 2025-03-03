using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LMSActivity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Binary operators
            Vector v1 = new Vector(2, 3);
            Vector v2 = new Vector(4, 5);
            Vector result = v1 + v2;
            Console.WriteLine("v1 + v2 = " + result);

            // Assignment operators
            int x = 5;
            x += 3;
            Console.WriteLine("x += 3: " + x);


            // Unary operators
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber result3 = -c1;
            Console.WriteLine("-c1 = " + result3);

            int y = 10;
            double d = y;
            Console.WriteLine("int to double: " + d);

            double e = 20.5;
            int z = (int)e;
            Console.WriteLine("double to int: " + z);
        }
    }

    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public struct ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public ComplexNumber(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator -(ComplexNumber c)
        {
            return new ComplexNumber(-c.Real, -c.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
