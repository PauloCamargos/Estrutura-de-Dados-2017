using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRecursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonnacci n = new Fibonnacci();
            n.n = 3;


            Console.WriteLine("Fib de " + n.n.ToString() + ": " + n.calcFibonnacci(n.n));
            Console.Read();
        }
    }
}
