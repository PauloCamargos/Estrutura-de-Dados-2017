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

            int[] lista = { 8, 10, 3, 1, 6, 14, 4, 13, 7 };
            int[] listaOrdenada;
            ArvoreBin arvoreBin = new ArvoreBin();


            Console.Write("Lista original: [");
            foreach (int i in lista)
            {
                Console.Write(i + ", ");
                arvoreBin.inserir(i);
            }
            Console.WriteLine("]");

            arvoreBin.ordenaLsita();
            listaOrdenada = arvoreBin.retornalista();

            Console.Write("Lista ordenada: [");
            foreach (int i in listaOrdenada)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("]");

            Console.WriteLine("Qnt de nós: " + arvoreBin.contarNos());
            Console.WriteLine("Qnt de folhas: " + arvoreBin.contarFolhas());
            
            Console.Read();
        }
    }
}
