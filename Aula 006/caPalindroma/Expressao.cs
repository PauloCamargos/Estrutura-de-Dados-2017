using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPalindroma
{
    class Expressao
    {
        private String frase;
        public Pilha p = new Pilha();


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
            exp = exp.Replace(" ", "");
           // char[] caracteres = exp.ToCharArray();
            foreach(char car in exp)
            {
                p.push(car);
            }
        }

        public bool isPalindrome()
        {
            bool estado = false;
            Pilha p_reversa = p.reverteElementos();
            estado  = p.isEqual(p_reversa);
            if (estado && p.qnt_elementos == p_reversa.qnt_elementos)
            {
                Console.WriteLine("A expressão '" + frase + "' é palindroma.");
            }
            else
            {
                Console.WriteLine("A expressão '" + frase + "' é NÃO É palindroma.");
            }
            return estado;
        }
    }
}
