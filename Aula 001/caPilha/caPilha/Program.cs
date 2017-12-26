using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class Program
    {
        static void Main(string[] args)
        {

            Pilha p = new Pilha();

            p.push(8);
            p.push(5);
            p.push(6);

            p.print();

            int x = p.Pop();
            int y = p.Pop();

            Console.WriteLine("\n" + x);
            Console.WriteLine("\n" + y);

            p.print();
            Console.Read();


        }
    }
}
