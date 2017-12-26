using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFormula_Matematica
{
    class Expressao
    {
        private char[] elementos;
        private Pilha<char> formula= new Pilha<char>();

        public Expressao()
        {
            elementos = null;
            //formula = null;
        }

        public char[] Elementos { get => elementos; set => elementos = value; }
        //internal Pilha<char> Formula { get => formula; set => formula = value; }

        public bool verifica()
        {
            bool estado = true;

            foreach (char i in this.Elementos)
            {
                if( i.Equals('{') || i.Equals('[') || i.Equals('(') )
                {
                   this.formula.push(i);
                }

                if (i.Equals('}') && formula.Topo.Data.Equals('{'))
                {
                    this.formula.pop();
                }
                
                if (i.Equals(']') && formula.Topo.Data.Equals('['))
                {
                    this.formula.pop();
                }

                if (i.Equals(')') && formula.Topo.Data.Equals('('))
                {
                    this.formula.pop();
                }
                                
            }//fim do foreach

            if (formula.Topo != null)
            {
                estado = false;
                formula.print();

            }


            return estado;

        }//fim do verifica
        


    }//fim da classe
}
