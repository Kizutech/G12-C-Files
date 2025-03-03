using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Laboratory_Exercise1_ARG_Sanchez_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("x + ");
                string str = Console.ReadLine();
                if (str == "exit")
                {
                    Console.WriteLine("Program has stopped");
                    break;
                }
                else
                {
                    int x = Convert.ToInt32(str);
                    Console.Write("y = ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int sum = x + y;
                    Console.WriteLine("Result: {0}", sum);
                }
            }
            while (true);
        }
    }
}
