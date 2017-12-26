using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab01
{
    class Menu
    {
        public byte opcao;

        public Menu(byte _opcao)
        {
            this.opcao = _opcao;
        }

        public Menu()
        {
            this.opcao = 0;
        }

        public void printMenu()
        {
            Console.WriteLine("----------------------- MENU ------------------------");
            Console.WriteLine("[1] - Inserir elemento");
            Console.WriteLine("[2] - Remover elemento");
            Console.WriteLine("[3] - Imprimir MAIOR elemento");
            Console.WriteLine("[4] - Imprimir MENOR elemento");
            Console.WriteLine("[5] - Imprimir pilha");
            Console.WriteLine("[6] - SAIR");
        }
    }
}
