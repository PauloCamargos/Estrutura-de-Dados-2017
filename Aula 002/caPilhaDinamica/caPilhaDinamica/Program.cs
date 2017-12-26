using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("-------------- PILHA DINÂMICA ------------");
            Console.WriteLine("------------------------------------------\n");

            Pilha pilha = new Pilha();

            pilha.push(4);
            pilha.push(5);
            pilha.push(6);
            pilha.push(7);

            pilha.print();

            pilha.pop();
            pilha.pop();

            pilha.print();

            Console.Read();
        }
    }
}
