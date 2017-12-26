using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caBuscaBinaria
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] a = { 2, 5, 8, 12, 15, 20, 27 };
            //int[] sortedArray = (from element in a orderby element ascending select element).ToArray();
            BuscaBinaria vetor = new BuscaBinaria(a);

            Console.WriteLine(vetor.binarySearch(a, 20));
            Console.Read();
        }
    }
}
