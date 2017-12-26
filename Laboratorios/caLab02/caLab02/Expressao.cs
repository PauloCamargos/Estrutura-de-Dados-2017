using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab02
{
    class Expressao
    {
        public String expressao;
        Pilha pilha_elementos = new Pilha();

        String Elemento { get => expressao; set => expressao = value; }

        public Expressao()
        {
            expressao = "";
        }

        public Expressao (String expressao)
        {
            this.expressao = expressao;
        }

        public void setExpressao()
        {
            Console.WriteLine("Escreva uma expressão matemática para ser avaliada: ");
            this.expressao = Console.ReadLine();
        }

        public String getExpressao()
        {
            Console.WriteLine("-------------------------- Sua expressão é: ");
            Console.WriteLine(expressao);
            empilharExpressao();
            return expressao;
        }


        public void empilharExpressao()
        {
            for (int i = 0; i < expressao.Length; i++)
            {
                char caracter = expressao[i];
                if ( caracter == '[' || caracter == '{' || caracter == '(' )
                {
                    pilha_elementos.push(caracter.ToString());
                }
                compararElementos(caracter.ToString()); 
            }
        }

        public void compararElementos(String caracter)
        {
            if (caracter == "]" && pilha_elementos.Topo.Elemento == "[")
                pilha_elementos.pop();
            if (caracter == ")" && pilha_elementos.Topo.Elemento == "(")
                pilha_elementos.pop();
            if (caracter == "}" && pilha_elementos.Topo.Elemento == "{")
                pilha_elementos.pop();
        }

        public void testarExpressao()
        {
            if(pilha_elementos.isEmpty())
            {
                Console.WriteLine("Expressão válida.");
            }
            else
            {
                //Console.WriteLine("INVÁLIDA");
                Console.Write("Inválida. Desbalanceamento de parênteses, colchetes ou chaves.");
            }
            
        }

    }
}
