/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 June 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Use example of a binary search tree
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvore_binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> arvoreBinaria = new BinaryTree<int>();

            arvoreBinaria.isEmpty();
            arvoreBinaria.insertInOrder(25);
            arvoreBinaria.insertInOrder(20);
            arvoreBinaria.insertInOrder(20);
            arvoreBinaria.insertInOrder(36);
            arvoreBinaria.insertInOrder(36);
            arvoreBinaria.insertInOrder(10);
            arvoreBinaria.insertInOrder(23);
            arvoreBinaria.insertInOrder(23);
            arvoreBinaria.insertInOrder(22);
            arvoreBinaria.print();
            Console.WriteLine();

            arvoreBinaria.find(25);
            Console.WriteLine();

            arvoreBinaria.remove(10);
            arvoreBinaria.print();


            Console.WriteLine();
            Console.WriteLine(arvoreBinaria.find(25).getData());
            Console.ReadKey();
        }
    }
}
