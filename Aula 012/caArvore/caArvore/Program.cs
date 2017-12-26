using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvore
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ARVORE BINÁRIA: ");

            ArvoreBin arvoreBin = new ArvoreBin();

            arvoreBin.inserir(25);
            arvoreBin.inserir(20);
            arvoreBin.inserir(30);
            arvoreBin.inserir(36);
            arvoreBin.inserir(18);
            arvoreBin.inserir(10);
            arvoreBin.inserir(23);
            arvoreBin.inserir(40);
            //criar o método remover
            arvoreBin.imprimirArvore();
            Console.Read();

        }
    }
}
