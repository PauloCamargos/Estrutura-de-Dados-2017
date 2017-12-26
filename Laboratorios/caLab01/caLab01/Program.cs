using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;

            int aux = 1;

            while (aux == 1)
            {
                escritor.WriteLine("----------------------- MENU -------------------------");
                escritor.WriteLine("[1] - Inserir elemento");
                escritor.WriteLine("[2] - Remover elemento");
                escritor.WriteLine("[3] - Imprimir MAIOR elemento");
                escritor.WriteLine("[4] - Imprimir MENOR elemento");
                escritor.WriteLine("[5] - Imprimir pilha");
                escritor.WriteLine("[6] - SAIR");
                escritor.WriteLine("------------------------------------------------------");
                int opcao = Convert.ToInt32(leitor.ReadLine());
                switch (opcao)
                {
                    case 1:
                        escritor.Write("Digite o elemento a ser inserido: ");
                        String elemento = leitor.ReadLine();
                        int valor = Convert.ToInt32(elemento);
                        pilha.push(valor);
                        Console.Clear();
                        break;
                    case 2:
                        int auxiliar = pilha.pop();
                        Console.Clear();
                        break;
                    case 3:
                        pilha.maxElemento();
                        break;
                    case 4:
                        pilha.minElemento();
                        break;
                    case 5:
                        pilha.print();
                        break;
                    case 6:
                        aux = 0;
                        break;
                }
            }
        }
    }
}
