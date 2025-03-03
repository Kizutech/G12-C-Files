using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PerformanceTask1
{
    // Person Class
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Student Class
    public class Student : Person
    {
        public string Grade { get; set; }
        public string[] Subjects { get; set; }

        public Student(string name, int age, string grade, string[] subjects)
            : base(name, age)
        {
            Grade = grade;
            Subjects = subjects;
        }
    }

    // SMSC
    public class StudentManagementSystem
    {
        private List<Student> students = new List<Student>();
        private Dictionary<string, double[,]> studentGrades = new Dictionary<string, double[,]>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            studentGrades[student.Name] = new double[student.Subjects.Length, 10];
        }

        public void RemoveStudent(string name)
        {
            var student = students.Find(s => s.Name == name);
            if (student != null)
            {
                students.Remove(student);
                studentGrades.Remove(name);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void ViewStudents()
        {
            Console.WriteLine("List of Students:");
            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}, Subjects: {string.Join(", ", student.Subjects)}");
            }
        }

        public void AddGrade(string studentName, string subject, double grade, int index)
        {
            if (studentGrades.ContainsKey(studentName))
            {
                var student = students.Find(s => s.Name == studentName);
                int subjectIndex = Array.IndexOf(student.Subjects, subject);
                if (subjectIndex >= 0 && index < 10)
                {
                    studentGrades[studentName][subjectIndex, index] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid subject or index.");
                }
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("Student not found.");
            }
        }

        public void ViewGrades(string studentName)
        {
            if (studentGrades.ContainsKey(studentName))
            {
                var grades = studentGrades[studentName];
                var student = students.Find(s => s.Name == studentName);
                Console.WriteLine($"Grades for {studentName}:");
                for (int i = 0; i < student.Subjects.Length; i++)
                {
                    Console.Write($"{student.Subjects[i]}: ");
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(grades[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("Student not found.");
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManagementSystem sms = new StudentManagementSystem();

            // Students UwU
            var subjects = new string[] { "Math", "Science", "English" };
            var student1 = new Student("Renz", 17, "12 ICT SHS", subjects);
            var student2 = new Student("Albert", 18, "12 ICT SHS ", subjects);
            var student3 = new Student("Dustin", 17, "12 ICT SHS ", subjects);
            var student4 = new Student("Mathew", 18, "12 ICT SHS ", subjects);

            // Add students
            sms.AddStudent(student1);
            sms.AddStudent(student2);
            sms.AddStudent(student3);
            sms.AddStudent(student4);

            // View students
            sms.ViewStudents();

            // Add grades
            sms.AddGrade("Renz", "Math", 90, 0);
            sms.AddGrade("Renz", "Science", 89, 0);
            sms.AddGrade("Renz", "English", 88, 0);

            sms.AddGrade("Albert", "Math", 85, 0);
            sms.AddGrade("Albert", "Science", 80, 0);
            sms.AddGrade("Albert", "English", 80, 0);

            sms.AddGrade("David", "Math", 79, 0);
            sms.AddGrade("David", "Science", 85, 0);
            sms.AddGrade("David", "English", 79, 0);

            sms.AddGrade("Mathew", "Math", 95, 0);
            sms.AddGrade("Mathew", "Science", 90, 0);
            sms.AddGrade("Mathew", "English", 89, 0);

            // View grades
            sms.ViewGrades("Renz");
            sms.ViewGrades("Albert");
            sms.ViewGrades("David");
            sms.ViewGrades("Mathew");

            // Remove a student
            sms.RemoveStudent("Renz");
            sms.ViewStudents();
        }
    }
}
