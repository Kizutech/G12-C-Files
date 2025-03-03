using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        class Person
        {
            public int age;
            public string name;
        }
        static void Main(string[] args)
        {
            Person bob = new Person(); //instantiation of object bob
            bob.name = "Bobby"; //assignment of values to member field name
            bob.age = 3; //assignment of values to member field age
                         
            Console.WriteLine(bob.age); 
            //WriteLine method outputs 3
        }
    }
}
