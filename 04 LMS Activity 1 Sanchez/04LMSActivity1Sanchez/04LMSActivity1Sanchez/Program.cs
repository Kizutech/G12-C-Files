using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04LMSActivity1Sanchez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Renz Albert Sanchez", 16, "ICT");

            Console.WriteLine("STI Student Information");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Name: {student1.Name}");
            Console.WriteLine($"Age: {student1.Age}");
            Console.WriteLine($"Course: {student1.Strand}");
        }
    }
    class Student
    {
        // Constructor
        public Student(string name, int age, string strand)
        {
            Name = name;
            Age = age;
            Strand = strand;
        }

        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string strand { get; set; }
        public object Strand { get; internal set; }
    }
}
