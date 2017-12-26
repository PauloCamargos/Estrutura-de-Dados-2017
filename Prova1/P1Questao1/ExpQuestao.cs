using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Questao1
{
    class ExpQuestao
    {
        private String frase;
        public Pilha x = new Pilha();
        public Pilha y = new Pilha();

        public Expressao(string frase)
        {
            this.frase = frase;
        }

        public Expressao()
        {
            this.frase = null;
        }

        public void constroiPilha(String exp)
        {
            this.frase = exp;
            Char delimiter = 'C';
            String[] substrings = exp.Split(delimiter);
            String s_x = substrings[0];
            String s_y = substrings[1];
        }
        //foreach (char car in s_x)
        //{
        //    x.push(car);
        //}

        //foreach(char car in s_y)
        //{
        //    y.push(car);
        //}
    }

    public bool isPalindrome()
    {
        bool estado = false;
        estado = x.isEqual(y);
        if (estado && x.qnt_elementos == y.qnt_elementos)
        {
            Console.WriteLine("A expressão '" + frase + "' É palindroma.");
        }
        else
        {
            Console.WriteLine("A expressão '" + frase + "' NÃO está OK.");
        }
        return estado;
    }
}
}
