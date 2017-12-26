using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraQuestao
{
    class Program
    {
        static void Main(string[] args)
        {
                String expressao;
               
                    Expressao exp = new Expressao();
                    Console.WriteLine("Entre 'quit' para sair.\nInsira uma expessão ");
                    expressao = Console.ReadLine();
                    exp.constroiPilha(expressao);
                    
                    exp.isPalindrome();
                    Console.WriteLine("-------------------------------\n");
            Console.Read();
            }
        }
    }

