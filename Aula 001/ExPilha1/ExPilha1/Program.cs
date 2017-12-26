using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPilha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            pilha.push(5);
            pilha.push(4);
            pilha.push(3);
            pilha.push(2);
            pilha.push(1);

            pilha.print();

            pilha.pop();
            pilha.pop();

            pilha.print();

            Console.Read();
        }
    }
}
