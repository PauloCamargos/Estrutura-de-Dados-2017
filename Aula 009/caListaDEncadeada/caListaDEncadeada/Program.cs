using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criar menu de opcoes.
            Lista l = new Lista();

            l.insereCabeca(1);
            l.insereCabeca(5);
            l.insereCabeca(10);
            l.imprimeDireita();
            l.imprimeEsquerda();

            //l.remove(1);
            //l.imprimeesquerda();
            //l.imprimedireita();

            // 10 - 5 - 1 - 15

            l.InsereCauda(15);
            l.imprimeDireita();
            l.EncontraPosPElem(15);
            l.EncontraElePPos(5);
            l.contarElementos();
            l.SomaElemento();
            l.imprimeDireita();

            l.inserirNaPosicao(2);
            l.editarPosicao(2);

            Console.Read();
        }
    }
}
