using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();

            int aux = 1;

            while (aux == 1)
            {
                Console.WriteLine("[1] Cadastrar aluno");
                Console.WriteLine("[2] Remover aluno.");
                Console.WriteLine("[3] Imprimir alunos cadastrados (ordem cres. de matric).");
                Console.WriteLine("[4] Sair.");
                Console.Write("---------------- OPÇÃO: ");

                int opcao = int.Parse(System.Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Entre com o nome: ");
                        String nome = Console.ReadLine();
                        Console.WriteLine("Entre com a matrícula: ");
                        int matricula = int.Parse(System.Console.ReadLine());
                        Aluno aluno_novo = new Aluno(nome, matricula);
                        l.insereCabeca(aluno_novo);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Entre com a matricula a ser removida: ");
                        matricula = int.Parse(System.Console.ReadLine());
                        l.remove(matricula);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        l.imprimirOrdenado();
                        Console.ReadLine();
                        Console.Clear(); break;

                    case 4:
                        aux = 0;
                        return;
                }
            }


            Console.Read();
        }
    }
}
