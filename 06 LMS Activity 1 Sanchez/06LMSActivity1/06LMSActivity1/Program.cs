using System;
using System.Collections.Generic;

namespace _06LMSActivity1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    public class Student : Person
    {
        public string StudentID { get; set; }
        public string Section { get; internal set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Student ID: {StudentID}");
        }
    }
    public class SDatabase
    {
        private List<Person> people = new List<Person>();

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public void DisplayAll()
        {
            foreach (var person in people)
            {
                person.DisplayInfo();
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SDatabase database = new SDatabase();

            Student student = new Student
            {
                Name = "Renz",
                Age = 16,
                Section = "ICT301",
                StudentID = "02000338512"
            };
            database.AddPerson(student);
            database.DisplayAll();
            Console.ReadLine();
        }
    }
}
