/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 Maio de 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Primeira prova de Estrutura de Dados
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_template
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> lista = new DoublyLinkedList<int>();
            int op, pos, ele;

            do
            {
                Console.Clear();
                Console.WriteLine("[1] Insira um elemento em ordem crescente");
                Console.WriteLine("[2] Insira um elemento a partir da posição (i)");
                Console.WriteLine("[3] Remova um elemento da posição (i)");
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
                        lista.insertAscending(ele);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Insira o elemento: ");
                        ele = int.Parse(System.Console.ReadLine());
                        Console.Write("\nInsira a posição: ");
                        pos = int.Parse(System.Console.ReadLine());
                        lista.insertAscendingAt(ele, pos);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Insira a posição que deseja adicionar: ");
                        pos = int.Parse(System.Console.ReadLine());
                        lista.removeAt(pos);
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
