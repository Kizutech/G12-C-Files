using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Greetings for users
            Console.WriteLine();
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("==================================");

            while (true)
            {
                //Texts
                Console.WriteLine();
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.WriteLine("\nPlease enter an operation (+, -, *, /) or type 'exit' to quit.");
                string operation = Console.ReadLine();

                //if, else if, else statement
                if (operation == "exit")
                {
                    //Goodbye greetings with Pokemon Calcu:)
                    Console.WriteLine();
                    Console.WriteLine("Bye");
                    Console.WriteLine("\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈████≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈█████≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈███████\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈████████\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈█████████\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈███▒▒████\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈████▒▒▒███\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈███▒▒▒▒▒██\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈███▒▒▒▒▒▒██\r\n≈≈≈≈≈≈████████≈≈≈≈≈≈≈≈≈≈≈≈██▒▒▒▒▒▒▒██\r\n≈≈≈≈███████████≈≈≈≈≈≈≈≈≈≈≈██▒▒▒▒▒▒▒██\r\n≈≈██████████████≈≈≈≈≈≈≈≈≈≈█▒▒▒▒▒▒▒▒██\r\n███████████▒▒▒▒██≈≈≈≈≈≈≈≈≈█▒▒▒▒▒▒▒▒██\r\n████████▒▒▒▒▒▒▒▒██≈≈≈≈≈≈≈≈█▒▒▒▒▒▒▒▒██\r\n██████▒▒▒▒▒▒▒▒▒▒▒█≈≈████≈≈██▒▒▒▒▒▒▒██\r\n███████▒▒▒▒▒▒▒▒▒▒███████████▒▒▒▒▒▒▒██\r\n███████▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒██▒▒▒▒▒▒▒██\r\n≈█████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██≈\r\n≈≈█████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██≈≈\r\n≈≈≈█████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██≈≈≈\r\n≈≈≈≈██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██≈≈≈≈\r\n≈≈≈≈≈██████▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒██▒██≈≈≈≈\r\n≈≈≈≈≈≈████████▒▒█▌▐█▒▒▒▒▒▒▒█▌▐█▒█≈≈≈≈\r\n≈≈≈≈≈≈≈≈█████▒▒▒█▌▐█▒▒▒▒▒▒▒█▌▐█▒█≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈█▒▒▒████▒▒▒▒▒▒▒████▒██≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈█▒▒▒████▒▒▒▒█▒▒████▒██≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈██▒▒▒███▒▒▒▒▒▒▒▒▒███▒▒█≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈██▒▒▒▒▒▒▒▒██████▒▒▒▒▒▒█≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈██▒███▒▒▒▒██████▒▒▒████≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈████▒██▒▒▒██████▒▒█▒▒██≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈██▒▒▒█▒▒▒██████▒▒█▒▒██≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈██▒▒▒█▒▒▒██████▒▒█▒▒█≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈██▒▒▒█▒▒▒██████▒▒█▒▒█≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈██▒██▒▒▒▒████▒▒▒█▒█≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈████▒▒▒▒▒▒▒▒▒▒▒▒▒▒██≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈██████▒▒▒▒▒▒▒▒▒▒▒▒▒██≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈██▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒█████≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈███▒▒▒▒▒██▒▒▒▒▒▒▒██▒▒▒███≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈█▒▒▒▒▒▒██████████▒▒▒▒▒██≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈██▒▒▒▒▒▒█████████▒▒▒▒▒██≈≈≈\r\n≈≈≈≈≈≈≈≈≈████▒▒▒▒▒█████████▒▒▒▒██≈≈≈≈\r\n≈≈≈≈≈≈≈≈███████▒▒▒███▒████▒▒▒▒██≈≈≈≈≈\r\n≈≈≈≈≈≈███████████▒▒██▒▒▒█▒▒▒███≈≈≈≈≈≈\r\n≈≈≈≈≈██████████▒▒▒▒█▒▒▒▒█▒███≈≈≈≈≈≈≈≈\r\n≈≈≈≈███████████▒▒▒▒▒▒▒▒▒▒▒██≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈████████≈≈██▒▒▒▒▒▒▒▒▒▒█≈≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈██████≈≈███▒▒▒▒▒▒▒▒▒▒█≈≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈████≈≈██▒▒█▒▒▒▒▒▒▒▒▒█≈≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈███≈≈██▒▒▒▒█▒▒▒▒▒▒▒██≈≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈██▒▒▒▒████▒▒▒█▒█≈≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈█▒▒▒▒▒█≈≈████▒▒██≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈█▒█▒█▒█≈≈≈≈█▒▒▒▒█≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈█████≈≈≈≈≈█▒▒▒▒█≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈█▒▒▒▒█≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈█▒▒▒▒█≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈█▒█▒█≈≈≈≈≈≈≈≈≈\r\n≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈███≈≈≈≈≈≈≈≈≈≈\r\n");
                    break;
                }

                try
                {
                    Console.WriteLine("Please enter the first number:");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the second number:");
                    int num2 = int.Parse(Console.ReadLine());

                    if (operation == "+")
                    {
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    }
                    else if (operation == "-")
                    {
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    }
                    else if (operation == "*")
                    {
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    }
                    else if (operation == "/")
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        else
                        {
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid operation. Please enter +, -, *, /, or 'exit'.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter numbers only.");
                }
            }
        }
    }
}
