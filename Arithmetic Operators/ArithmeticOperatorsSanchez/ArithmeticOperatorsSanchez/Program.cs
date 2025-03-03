using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperatorsSanchez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;

            // Addition +
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);

            // Subtraction -
            int difference = a - b;
            Console.WriteLine("Difference: " + difference);

            // Multiplication *
            int product = a * b;
            Console.WriteLine("Product: " + product);

            // Division (integer division) /
            int quotient = a / b;
            Console.WriteLine("Quotient: " + quotient);

            // Ramainder 
            int remainder = a % b;
            Console.WriteLine("Remainder: " + remainder);

            // Exponentiation with Math.Pow
            double result = Math.Pow(a, b);
            Console.WriteLine("Result (exponentiation): " + result);

            // Floating-point division
            double c = 10.5;
            double d = 2.0;
            double floatQuotient = c / d;
            Console.WriteLine("Floating-point quotient: " + floatQuotient);

            Console.ReadLine();
        }
    }
}
