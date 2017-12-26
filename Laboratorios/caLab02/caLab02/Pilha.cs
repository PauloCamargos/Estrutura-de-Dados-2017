using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab02
{
    class Pilha
    {
        private NoPilha topo;

        public Pilha()
        {
            this.topo = null;
        }

        internal NoPilha Topo { get => topo; set => topo = value; }

        public void push(String elemento)
        {
            NoPilha novo = new NoPilha(elemento);
            novo.Next = topo;
            topo = novo;

        }

        public void pop()
        {
            String elemento = topo.Elemento;
                topo = topo.Next;
        }

        public void print()
        {
            if (this.isEmpty())
            {
                Console.WriteLine(' ');
            }
            else
            {
                NoPilha temp = topo;
                while (temp != null)
                {
                    Console.WriteLine(temp.Elemento);
                    temp = temp.Next;
                }
            }
        }

        public int qntElementos()
        {
            int qnt = 0;
            if (this.isEmpty())
            {
                return qnt;
            }
        
            else
            {
                NoPilha temp = topo;
                while (temp != null)
                {
                    Console.WriteLine(temp.Elemento);
                    temp = temp.Next;
                    qnt++;
                }
                return qnt;
            }

        }

        public bool isEmpty()
        {
            if(topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
