using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            String expressao;
            while (true)
            {
                Expressao exp = new Expressao();
                Console.WriteLine("Entre 'quit' para sair.\nInsira uma expessão ");
                expressao = Console.ReadLine();
                exp.constroiPilha(expressao);
                if (expressao == "quit")
                    break;
                exp.isPalindrome();
                Console.WriteLine("-------------------------------\n");
            }
        }
    }
}
