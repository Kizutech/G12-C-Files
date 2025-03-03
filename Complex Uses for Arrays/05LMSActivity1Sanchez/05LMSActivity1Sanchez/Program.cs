using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LMSActivity1Sanchez
{
    public class StringArrayManager
    {
        // Private
        private string[] strings;

        // Constructor
        public StringArrayManager(int size)
        {
            strings = new string[size];
        }

        // Property
        public string[] Strings
        {
            get { return strings; }
            set
            {
                if (value.Length == strings.Length)
                {
                    strings = value;
                }
                else
                {
                    throw new ArgumentException("Array size mismatch.");
                }
            }
        }

        public void DisplayStrings()
        {
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StringArrayManager manager = new StringArrayManager(3);
            manager.Strings = new string[] { "Renz Albert Sanchez", "ICT301", "C#" };
            manager.DisplayStrings();
        }
    }
}
