using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTemplatePilha
{
    class Pilha<TAD> : Object //Tipo abstrado de dado (TAD)
    {
        //Atributos
        private NohPilha<TAD> topo;

        //Construtor
        public Pilha()
        {
            topo = null;
        }

        //Métodos
        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void push(TAD n)
        {
            if (this.isEmpty())
            {
                NohPilha<TAD> novo = new NohPilha<TAD>(n);
                topo = novo;
            }
            else
            {
                NohPilha<TAD> novo = new NohPilha<TAD>(n);
                novo.setNext(topo);
                topo = novo;
            }
        }//FIM DO MÉTODO push

        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia!!");
            }
            else
            {
                Console.WriteLine("Elementos da pilha: ");
                NohPilha<TAD> temp = topo;
                while (temp != null)
                {
                    Console.WriteLine(temp.getData());
                    temp = temp.getNext();
                }
            }
        }

        public TAD pop()
        {
            TAD desempilhado;
            if (this.isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return topo.getData();
            }
            else
            {
                desempilhado = topo.getData();
                topo = topo.getNext();
                Console.WriteLine("Desempilhado: " + desempilhado);
                return desempilhado;
            }
        }//FIM DO MÉTODO  pop()

    }
}

