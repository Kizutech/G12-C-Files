using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        // Calculator Class
        public class Calculator
        {
            // Arithmetic Operations
            public double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            public double Subtract(double num1, double num2)
            {
                return num1 - num2;
            }

            public double Multiply(double num1, double num2)
            {
                return num1 * num2;
            }

            public double Divide(double num1, double num2)
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero!");
                }
                return num1 / num2;
            }
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true) // Loop
            {
                Console.WriteLine(); // Blank
                Console.WriteLine("Simple Calculator"); // Simple Calculator using C# program
                Console.WriteLine("Instructions:"); // Instructions on Operators
                Console.WriteLine("(1) Addition, (2) Subtraction, (3) Multiplication, (4) Division, (5) Exit"); // Type 1,2,3,4,5
                Console.WriteLine("Select an operation:"); // Text
                Console.WriteLine("1. Addition"); // Add
                Console.WriteLine("2. Subtraction"); // Subtract
                Console.WriteLine("3. Multiplication"); // Multiply
                Console.WriteLine("4. Division"); // Divide
                Console.WriteLine("5. Exit"); // Exit this Program:)

                int operation = Convert.ToInt32(Console.ReadLine());

                if (operation == 5)
                {
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case 1:
                        result = calculator.Add(num1, num2);
                        break;
                    case 2:
                        result = calculator.Subtract(num1, num2);
                        break;
                    case 3:
                        result = calculator.Multiply(num1, num2);
                        break;
                    case 4:
                        result = calculator.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
