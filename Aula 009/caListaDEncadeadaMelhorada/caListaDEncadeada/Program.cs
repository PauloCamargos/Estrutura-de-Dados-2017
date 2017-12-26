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
            Lista l = new Lista();

            int aux = 1, valor, posicao;

            while (aux == 1)
            {
                Console.WriteLine("1 - Inserir elemento na cabeça.");
                Console.WriteLine("2 - Inserir elemento na cauda.");
                Console.WriteLine("3 - Remover elemento.");
                Console.WriteLine("4 - Imprimir lista (pela direita).");
                Console.WriteLine("5 - Imprimir lista (pela esquerda).");

                Console.WriteLine("6 - Inserir após posicão específica.");
                Console.WriteLine("7 - Inserir na posição específica.");
                Console.WriteLine("8 - Atualizar dado da posição.");
                Console.WriteLine("9 - Sair.");
                Console.Write("---------------- OPÇÃO: ");

                int opcao = int.Parse(System.Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Entre com o valor a ser INSERIDO NA CABEÇA: ");
                        valor = int.Parse(System.Console.ReadLine());
                        l.insereCabeca(valor);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Entre com o valor a ser INSERIDO NA CAUDA: ");
                        valor = int.Parse(System.Console.ReadLine());
                        l.insereCauda(valor);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Entre com a posição do elemento a ser REMOVIDO: ");
                        posicao = int.Parse(System.Console.ReadLine());
                        l.remove(posicao);
                        Console.Clear(); break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Elementos da lista (PELA DIREITA): ");
                        l.imprimeDireita();
                        Console.WriteLine("Pressione 'enter' para retornar ao menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Elementos da lista (PELA ESQUERDA): ");
                        l.imprimeEsquerda();
                        Console.WriteLine("Pressione 'enter' para retornar ao menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 6:
                        Console.Clear();
                        Console.Write("Insira posição para o elemento ser inserido (APÓS): ");
                        posicao = int.Parse(System.Console.ReadLine());
                        Console.Write("Insira o valor a ser inserido: ");
                        valor = int.Parse(System.Console.ReadLine());
                        l.inserirAposPosicao(posicao, valor);
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Console.Write("Insira posição (EXATA) para o elemento ser inserido: ");
                        posicao = int.Parse(System.Console.ReadLine());
                        Console.Write("Insira o valor a ser inserido: ");
                        valor = int.Parse(System.Console.ReadLine());
                        l.inserirAntesPosicao(posicao, valor);
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.Write("Insira a posição do elemento ser modificado: ");
                        posicao = int.Parse(System.Console.ReadLine());
                        Console.Write("Insira o valor a ser modificado: ");
                        valor = int.Parse(System.Console.ReadLine());
                        l.editarDataPosicao(posicao, valor);
                        Console.Clear();
                        break;
                    case 9:
                        aux = 0;
                        return;
                }
            }

            //////Criar menu de opcoes.
            ////Lista l = new Lista();

            //l.insereCabeca(1);
            //l.insereCabeca(5);
            //l.insereCabeca(10);
            //l.imprimeDireita();
            //l.imprimeEsquerda();

            //l.remove(1); // Remove(posicao);
            ////l.imprimeesquerda();
            ////l.imprimedireita();

            //// 10 - 5 - 1 - 15

            //l.insereCauda(15);
            //l.imprimeDireita();
            //l.EncontraPosPElem(15);
            //l.EncontraElePPos(3);
            //Console.WriteLine(l.contarElementos());
            //l.SomaElemento();
            //l.imprimeDireita();
            //Console.WriteLine(l.encontrarEm(2).Info);
            //Console.WriteLine("Qnt de elementos: " + l.contarElementos());

            ////l.EncontraElePPos
            ////Posicao começando em 1
            ////l.inserirAposPosicao(2, 1); //inserirNaPosicao(posicao, data);
            //l.inserirAntesPosicao(2,54);
            //l.imprimeDireita();
            //l.editarDataPosicao(2, 50); //editarDataPosicao(posicao, data);
            //l.imprimeDireita();


            Console.Read();
        }
    }
}
