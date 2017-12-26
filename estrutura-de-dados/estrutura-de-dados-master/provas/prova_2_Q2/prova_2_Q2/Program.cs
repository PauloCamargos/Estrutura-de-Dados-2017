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

namespace prova_2_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TESTING EXAMPLE
            DoublyLinkedList<string> lista = new DoublyLinkedList<string>();
            
            lista.insert("Yesterday all my troubles seemed so far away");
            lista.insert("Now it looks as though they're here to stay");
            lista.insert("Oh, I believe in yesterday");

            lista.print();
            Console.WriteLine();

            lista.replaceBy(1, "This was replaced!");
            lista.replaceBy(6, "This was replaced!");
            lista.insertAt("This was inserted here",1);

            lista.print();
            Console.ReadKey();
            */

            DoublyLinkedList<string> lista = new DoublyLinkedList<string>();
            int op, pos;
            string verso;

            do
            {
                Console.Clear();
                Console.WriteLine("[1] Insira um verso");
                Console.WriteLine("[2] Edite um verso");
                Console.WriteLine("[3] Insira um verso na poscição [i]");
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
                        verso = Console.ReadLine();
                        lista.insert(verso);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Qual verso deseja editar: ");
                        pos = int.Parse(System.Console.ReadLine());
                        Console.Write("\nO que deseja inserir?");
                        verso = Console.ReadLine();
                        lista.replaceBy(pos, verso);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Qual verso deseja editar: ");
                        pos = int.Parse(System.Console.ReadLine());
                        Console.Write("\nEm qual posição?");
                        verso = Console.ReadLine();
                        lista.insertAt(verso, pos);
                        break;
                    case 4:
                        Console.Clear();
                        lista.print();
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
