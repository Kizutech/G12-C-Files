using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLMSActivity3
{
    internal class Program
    {
        static int Fact(int num)
        {
            if (num == 1)
                return 1;
            else return num * Fact(num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fact(6));
        }
    }
}
