/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 May 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Exemplo de uso de uma lista utilizando tipos abstratos de dados
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

            lista.insertAscending(1);
            lista.insertAscending(12);
            lista.insertAscending(25);
            lista.insertAscending(34);
            lista.print();
            lista.insertAscendingAt(5,4);

            lista.print();
            Console.WriteLine(lista.isAscendingOrder());
            lista.removeAt(5);
            lista.print();
            Console.ReadKey();
        }
    }
}
