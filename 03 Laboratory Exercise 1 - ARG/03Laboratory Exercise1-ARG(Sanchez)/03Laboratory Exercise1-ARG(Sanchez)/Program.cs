using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Laboratory_Exercise1_ARG_Sanchez_
{
    internal class Program
    {
        static void DrawPyramid(int n)
        {
            //Some code will go here
            for (int i = 1; i <= n; i++) 
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawPyramid(5);
        }
    }
}
