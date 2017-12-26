using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
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
                escritor.WriteLine("1 - Inserir elemento na pilha");
            escritor.WriteLine("2 - Remover elemento na pilha");
            escritor.WriteLine("3 - Imprimir pilha");
            escritor.WriteLine("4 - Sair");

                String op = leitor.ReadLine();
                int va = Convert.ToInt32(op);
                switch (va)
                {
                    case 1:
                        Console.Write("Digite o elemento a ser inserido:");
                        String elemento = leitor.ReadLine();
                        int valor = Convert.ToInt32(elemento);
                        pilha.push(valor);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Ultimo elemento retirado:");
                        int auxiliar = pilha.pop();
                        break;
                    case 3:
                        Console.Write("Estado da pilha: ");
                        pilha.print();
                        break;
                    case 4:
                        aux = 0;
                        break;
                }
                }





        }
    }
}
