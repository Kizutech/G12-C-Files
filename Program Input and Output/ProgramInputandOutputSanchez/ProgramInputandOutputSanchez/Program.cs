using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramInputandOutputSanchez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //It's just a simple Program with Input & Output

            //School Register
            Console.WriteLine("School Register");
            Console.WriteLine();

            //Name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //Age
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            //Section
            Console.Write("Enter your section: ");
            string section = Console.ReadLine();

            //School Strand
            Console.Write("Enter your strand: ");
            string strand = Console.ReadLine();

            //Space
            Console.WriteLine();

            //Greetings
            Console.WriteLine("Hello, " + name + "! " + "Welcome!");

            //Register Submitted
            Console.WriteLine("Your Register has been Submitted!");
        }
    }
}
