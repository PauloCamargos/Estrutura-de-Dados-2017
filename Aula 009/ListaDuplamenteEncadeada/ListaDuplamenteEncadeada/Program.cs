using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();

            l.Insere(10);
            l.imprimeDireita();
            l.imprimeEsquerda();

            l.Insere(20);
            l.imprimeDireita();
            l.imprimeEsquerda();

            l.Insere(30);
            l.imprimeDireita();
            l.imprimeEsquerda();

            l.Busca(10);

            Console.Read();
        }
    }
}
