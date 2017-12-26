using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPalindroma
{
    class Program
    {
        static void Main(string[] args)
        {
           String expressao;
            while (true)
            {
                Expressao exp = new Expressao();
                Console.WriteLine("Entre 'quit' para sair.\nInsira com uma expessão ou palavra: ");
                expressao = Console.ReadLine();
                exp.constroiPilha(expressao);
                if(expressao == "quit")
                    break;
                exp.isPalindrome();
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
