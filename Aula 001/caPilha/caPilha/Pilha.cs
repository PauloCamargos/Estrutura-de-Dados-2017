using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class Pilha
    {
        private int[] pilhaArray = new int[5];
        private int topo;

        public Pilha()
        {
            topo = -1;
        }

        public bool isEmpty()
        {
            if (topo == -1)
                return true;
            else
                return false;
        }

        public void push(int n)
        {
            if (topo > 4)
            {
                Console.WriteLine("Pilha Cheia!");
            }
            else
            {
                topo++;
                pilhaArray[topo] = n;
            }
        }

        public int Pop()
        {
            int desempilhado = 0;
            if (topo == -1)
            {
                Console.WriteLine("Pilha Vazia!");
                return topo;
            }
            else
            {
                desempilhado = pilhaArray[topo];
                topo--;
                return desempilhado;
            }
        }

        public void print()
        {
            if(topo == -1)
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                int temp = topo;
                while (temp > -1)
                {
                    Console.WriteLine(pilhaArray[temp]);
                    temp--;
                }
            }
        }
    }
}
