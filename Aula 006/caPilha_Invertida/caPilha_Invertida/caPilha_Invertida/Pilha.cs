using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha_Invertida
{
    class Pilha<TAD> : Object
    {
        //Atributos
        private NohPilha<TAD> topo;
        //Getters e Setters
        internal NohPilha<TAD> Topo { get => topo; set => topo = value; }

        //Métodos
        public Pilha()
        {
            topo = null; // não foi inserido elemento

        }

        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;

        }

        public void push(TAD insertItem)
        {
            if (isEmpty())
                topo = new NohPilha<TAD>(insertItem);
            else
            {
                NohPilha<TAD> next = new NohPilha<TAD>(insertItem);
                next.NextNoh = topo;
                topo = next;
            }

        }//fim do método push

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");

            else
            {
                Console.WriteLine("Status atual da Pilha: \n");
                NohPilha<TAD> temp = topo;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.Data);
                    temp = temp.NextNoh;
                }//fim do while

            }//fim do else

        }

        public TAD pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return topo.Data;
            }
            else
            {
                TAD temp = topo.Data;

                topo = topo.NextNoh;
                return (temp);

            }
        }// fim do método pop

        public Pilha<TAD> inverte()
        {
            Pilha<TAD> p = new Pilha<TAD>();
            NohPilha<TAD> aux = this.Topo;

            //aux = this.Topo;
            while(aux != null)
            {
                p.push(aux.Data);
                aux = aux.NextNoh;
            }

            return p;


        }//fim do inverte
    }
}
