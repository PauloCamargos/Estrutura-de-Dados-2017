/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 July 2017
 Use it as you please. If we meet some day, and you think
 this stuff is helpful, you can buy me a beer

 Segunda prova de Estrutura de Dados
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_2_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TESTING EXAMPLE
            BinaryTree<int> arvoreBinaria = new BinaryTree<int>();

            arvoreBinaria.insertInOrder(8);
            arvoreBinaria.insertInOrder(3);
            arvoreBinaria.insertInOrder(10);
            arvoreBinaria.insertInOrder(1);
            arvoreBinaria.insertInOrder(6);
            arvoreBinaria.insertInOrder(14);
            arvoreBinaria.insertInOrder(4);
            arvoreBinaria.insertInOrder(7);
            arvoreBinaria.insertInOrder(13);

            Console.Write("Árvore\n");
            arvoreBinaria.print();
            Console.WriteLine();

            Console.Write("Node counter = ");
            Console.WriteLine(arvoreBinaria.nodeCounter());

            Console.Write("Leaf counter = ");
            Console.WriteLine(arvoreBinaria.leafCounter());
            Console.ReadKey();
            */

            BinaryTree<int> arvoreBinaria = new BinaryTree<int>();
            int op, ele;

            do
            {
                Console.Clear();
                Console.WriteLine("[1] Insira um elemento na árvore");
                Console.WriteLine("[2] Quantidade de nós");
                Console.WriteLine("[2] Quantidade de folhas");
                Console.WriteLine("[4] Imprima a lista");
                Console.WriteLine("[5] SAIR");
                Console.Write("\nEscolha uma opção: ");
                op = int.Parse(System.Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Insira o elemento que deseja adicionar: ");
                        ele = int.Parse(System.Console.ReadLine());
                        arvoreBinaria.insertInOrder(ele);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Quantidade de nós: ");
                        arvoreBinaria.nodeCounter();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Quantidade de folhas: ");
                        arvoreBinaria.leafCounter();
                        break;
                    case 4:
                        Console.Clear();
                        arvoreBinaria.print();
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (op != 5);
        }
    }
}
