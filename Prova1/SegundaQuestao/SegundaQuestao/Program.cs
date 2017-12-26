using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaQuestao
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila f = new Fila();
            String opcao;
            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;

            int aux = 1;

            while (aux == 1)
            {
                Console.WriteLine("[1] - Insira um elemento");
                Console.WriteLine("[2] - Insira um elemento depois da posicao (i) (o fura-Fila)");
                Console.WriteLine("[3] - Remova um elemento");
                Console.WriteLine("[4] - Imprima a fila");
                Console.WriteLine("[5] - Sair");
                //String op = leitor.ReadLine();
                int va = Convert.ToInt32(leitor.ReadLine());
               
                switch (va)
                {
                    case 1:
                        Console.WriteLine("Entre com um elemento: ");
                        int ele = Convert.ToInt32(leitor.Read());
                        f.insereElemento(ele);
                        break;
                    case 2:
                        Console.WriteLine("Entre com a posicao");
                        f.furaFila(Convert.ToInt32(Console.Read()));
                        break;
                    case 3:
                        f.removeElemento();
                        break;
                    case 4:
                        f.printFila();
                        break;
                    case 5:
                        aux = 0;
                        break;
                }
            }

        }
    }
}



