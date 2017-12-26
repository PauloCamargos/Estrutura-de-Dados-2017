using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab01
{
    class Pilha
    {
        public NoPilha topo;

        public Pilha()
        {
            this.topo = null;
        }

        public bool isEmpty()
        {
            if(this.topo == null)
                return true;
            else
                return false;
        }

        public void push(int elemento)
        {
            NoPilha novoNo = new NoPilha(elemento);
            novoNo.Next = topo;
            topo = novoNo;
        }

        public int pop()
        {
            if (this.topo == null)
            {
                Console.WriteLine("Pilha Vazia");
                return 0;
            }
            else
            {
                topo = topo.Next;
                return topo.Elemento;
            }
        }

        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                NoPilha temp;
                temp = topo;
                Console.WriteLine("Elementos da pilha: ");
                while (temp != null)
                {
                    Console.WriteLine(temp.Elemento);
                    temp = temp.Next;
                }
            }
        }

        public int maxElemento()
        {
            int max = -1;
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return max;
            }
            else
            {
                NoPilha temp; temp = topo;
                max = temp.Elemento;
                temp = temp.Next;
                if(temp.Elemento > max)
                {
                    max = temp.Elemento;
                    temp = temp.Next;
                }
                Console.Write("Maior elemento: ");
                Console.WriteLine(max);
            }
            return max;
        }

        public int minElemento()
        {
            int min = -1;
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return min;
            }
            else
            {
                NoPilha temp; temp = topo;
                min = temp.Elemento;
                temp = temp.Next;
                if (temp.Elemento < min)
                {
                    min = temp.Elemento;
                    temp = temp.Next;
                }
                Console.Write("Menor elemento: ");
                Console.WriteLine(min);
            }
            return min;
        }
    }
}
