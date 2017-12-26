/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 Maio de 2017
 Use it as you please. If we meet some day, and you think
 this stuff is helpful, you can buy me a beer

 Primeira prova de Estrutura de Dados
 Algoritmo para determinar se uma entrada do tipo xCy
 onde y é o inverso de x
 e.g. x = abb, y = bba
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> _pilha = new Stack<String>();
            Stack<String> _desempilha = new Stack<String>();
            String compara_pilha;
            String compara_desempilha;

            Console.Write("Digite a entrada: ");
            string s = Console.ReadLine();
            bool flag = false;

            //verifique se a string é de tamanho impar
            if (s.Length % 2 == 0)
            {
                flag = true;
                goto FIM;
            }

            //encontre o meio da string
            int meio = (s.Length) / 2;

            //Se o meio da string nao for um 'C' preciso fazer alguma coisa?
            if (s[meio] != 'C')
            {
                flag = true;
                goto FIM;
            }

            //Condições básicas cumpridas, empilhando primeira metade
            for (int i = 0; i < meio; i++)
                _pilha.Push(s[i].ToString());

            //Condições básicas cumpridas, empilhando segunda metade começando pelo fim
            for (int i = s.Length - 1; i > meio; i--)
                _desempilha.Push(s[i].ToString());


            //Desempilhando as duas e comparando
            for (int i = 0; i < meio; i++)
            {
                compara_pilha = _pilha.Pop();
                compara_desempilha = _desempilha.Pop();

                if (compara_desempilha != compara_pilha)
                {
                    flag = true;
                    goto FIM;
                }
            }

            Console.WriteLine("É do formato abbCbba");
            Console.ReadKey();

        FIM:
            {
                if (flag)
                {
                    Console.Write("Não é do formato abbCbba");
                    Console.ReadKey();
                }
            }
        }
    }
}
