using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LaboratoryExercise1 {
}
internal class Program
    {
        static void Main(string[] args)
        {
        int[,] numArray = { { 2, 3 }, { 5, 6 }, { 4, 6 } }; 
        for (int k = 0; k < 3; k++) {
             for (int j = 0; j < 2; j++) { 
                Console.Write(numArray[k, j] + " "); 
            } 
            Console.WriteLine(); } 
    }
}

