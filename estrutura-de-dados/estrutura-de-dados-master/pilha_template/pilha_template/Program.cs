/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 Maio de 2017
 Use it as you please. If we meet some day, and you think
 this stuff is helpful, you can buy me a beer
 
 Exemplo de uso de uma pilha utilizando tipos abstratos de dados
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_template
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de uso
            Stack<int> int_stack = new Stack<int>();
            Stack<String> string_stack = new Stack<String>();

            //Empilhando inteiros
            int_stack.push(1);
            int_stack.push(2);
            int_stack.push(3);

            //Empilhando strings
            string_stack.push("um");
            string_stack.push("dois");
            string_stack.push("três");

            //Mostrando as pilhas
            int_stack.print();
            string_stack.print();

            //Vendo o que está no topo
            Console.WriteLine(int_stack.peek());
            Console.WriteLine(string_stack.peek());

            //Tamanho da pilha
            Console.WriteLine(int_stack.size());
            Console.WriteLine(string_stack.size());


            Console.ReadKey();
        }
    }
}
