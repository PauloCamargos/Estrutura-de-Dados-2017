using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab03
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
            //arvoreBin.inserir(40);
            //arvoreBin.inserir(8);
            //arvoreBin.inserir(2);
            //arvoreBin.inserir(9);
            //arvoreBin.inserir(1);
            //arvoreBin.inserir(5);
            //arvoreBin.inserir(3);
            //arvoreBin.inserir(6);
            //arvoreBin.inserir(4);

            //criar o método remover
            //arvoreBin.imprimirArvore();

            arvoreBin.remove(30);
            arvoreBin.imprimirArvore();
            Console.Read();
        }
    }
}
